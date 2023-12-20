using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Script.Serialization;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Data.Linq;
using FTIS_IDCARD.Models;
using System.Security.Cryptography;
using Microsoft.Ajax.Utilities;
using System.Drawing.Imaging;
using System.Drawing;
using ZXing;                  // for BarcodeWriter
using ZXing.QrCode;           // for QRCode Engine
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
using System.Data;
using System.Configuration.Provider;
using System.Web.Management;
using ZXing.Aztec.Internal;
using ZXing.OneD;
using System.Diagnostics;

namespace FTIS_IDCARD.Controllers
{
    public class HomeController : Controller
    {
        public static bool _isQRcode = false;
        public static bool _isHeadshot = false; 
        public string _strEnCode = "";
        public string _strDeCode = "";
        public string _key = "#The4ncryp9Key";
        public static string _token = "";
        public static byte[] _pic = null;
        public static bool _isEn = false;

        /// <summary>
        /// DED 加密/解密
        /// </summary>
        public static class Des_En_De_Code
        {
            private class DesKeyIV
            {
                public Byte[] Key = new Byte[8];
                public Byte[] IV = new Byte[8];
                public DesKeyIV(string strKey)
                {
                    var sha = new SHA1CryptoServiceProvider();
                    var bpHash = sha.ComputeHash(Encoding.ASCII.GetBytes(strKey));
                    for (int i = 0; i < 8; i++) Key[i] = bpHash[i];
                    for (int i = 8; i < 16; i++) IV[i - 8] = bpHash[i];
                }
            }
            /// <summary>
            /// 加密
            /// </summary>
            /// <param name="key"></param>
            /// <param name="rawString"></param>
            /// <returns></returns>
            public static string DesEncrypt(string key, string rawString)
            {
                if (rawString.Length > 92160)
                    return "Error. Data String too large. Keep within 90Kb.";
                var keyIv = new DesKeyIV(key);
                var rbData = UnicodeEncoding.Unicode.GetBytes(rawString);

                var descsp = new DESCryptoServiceProvider();
                var desEncrypt = descsp.CreateEncryptor(keyIv.Key, keyIv.IV);

                using (var mOut = new MemoryStream())
                {
                    using (var cs = new CryptoStream(mOut, desEncrypt, CryptoStreamMode.Write))
                    {
                        cs.Write(rbData, 0, rbData.Length);
                        cs.FlushFinalBlock();
                        if (mOut.Length == 0)
                            return string.Empty;
                        else
                        {
                            var buff = mOut.ToArray();
                            return Convert.ToBase64String(buff, 0, buff.Length).Replace('+', '%');
                        }
                    }
                }
            }
            /// <summary>
            /// 解密
            /// </summary>
            /// <param name="key"></param>
            /// <param name="_encString"></param>
            /// <returns></returns>
            public static string DesDecrypt(string key, string _encString)
            {
                //20230927, add by markhong 特殊字元�
                if (_encString.IndexOf('�') > 0)
                    _encString = _encString.Replace("�", "%dA");

                string encString = _encString.Replace('%', '+');

                if (string.IsNullOrEmpty(encString)) return "ERROR: EncString is NULL!";

                var keyIv = new DesKeyIV(key);
                var descsp = new DESCryptoServiceProvider();
                var desDecrypt = descsp.CreateDecryptor(keyIv.Key, keyIv.IV);

                try {
                    using (var mOut = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(mOut, desDecrypt, CryptoStreamMode.Write))
                        {
                            byte[] bPlain = Convert.FromBase64CharArray(encString.ToCharArray(), 0, encString.Length);


                            cs.Write(bPlain, 0, (int)bPlain.Length);
                            cs.FlushFinalBlock();
                            return Encoding.Unicode.GetString(mOut.ToArray());
                        }
                    }
                } 
                catch
                {
                    return "*ERROR*. Decryption Failed.";
                }               
            }
        }

        /// <summary>
        /// 回傳基本資料與QRCode
        /// </summary>
        /// <returns></returns>
        public List<IDcard> GetEmpdataQRCode(string token)
        {
            //輸入加密ID，則從DB撈出資料，與製作QRcode，回傳前端
            string strDecode = Des_En_De_Code.DesDecrypt(_key, token);
            //ViewBag.strDecodeID = strDecode;
            GerenateQRCdoe(token);
            return ls_IDCard(strDecode);
        }

        /// <summary>
        /// 確認員編
        /// </summary>
        /// <returns></returns>
        public bool isFno(string Token)
        {
            string strDecode = Des_En_De_Code.DesDecrypt(_key, Token);

            if (strDecode.Contains("*ERROR*"))
                return false;

            using (Model1 db1 = new Model1())
            {
                var empdata = (from c in db1.F22cmmEmpData
                               where c.Fno == strDecode
                               select c).ToList();
                if (empdata.Count > 0)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 是否在職
        /// </summary>
        /// <returns></returns>
        public bool isQuit(string Token)
        {
            string strDecode = Des_En_De_Code.DesDecrypt(_key, Token);
            using (Model1 db1 = new Model1())
            {
                var empdata = (from c in db1.F22cmmEmpData
                               where c.Fno == strDecode
                               select c).ToList();

                if (empdata[0].IsQuit.ToString() == "Y")
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 是否有照片
        /// </summary>
        /// <returns></returns>
        public bool isPhoto(string Token)
        {
            string strDecode = Des_En_De_Code.DesDecrypt(_key, Token);
            using (Model1 db1 = new Model1())
            {
                var q = (from item in db1.F22cmmEmpData where item.Fno == strDecode select item.Headshot).SingleOrDefault();
                if (q != null)
                {
                    ViewBag.isPhoto = true;
                    return true;
                }
            }
            ViewBag.isPhoto = false;
            return false;
        }

        /// <summary>
        /// 產生token
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GenToken4ID(String id)
        {                                                        
            if (id != null)
            {               
                if ((id.IndexOf("F") < 0 && id.IndexOf("J") < 0) || id.Length > 6)
                {
                    TempData["message"] = "非正確員工編號";
                    return View();
                }
                _strEnCode = Des_En_De_Code.DesEncrypt(_key, id);
                ViewBag.strEncodeID = _strEnCode;
            }
            return View();
        }

        /// <summary>
        /// 首頁
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Index(string id , bool isEn = false)
        {
            ViewBag.isen = isEn;
            _isEn = isEn;
            _token = id;
            if (_token == null)
            {
                return View();
            }
            _isHeadshot = isPhoto(_token);

            if (isFno(_token))
            {
                if (isQuit(_token))
                {
                    TempData["message"] = isEn ? "Employee has left the company." : "非在職員工";
                    return View();
                }
                else {
                    var result = GetEmpdataQRCode(_token);
                    if (result?[0]?.Fno != null)
                    {
                        return View(result);
                    }
                    TempData["message"] = isEn ? "Employee Data Error." : "基本資料有誤";
                    return View();
                }
            }
            else {
                TempData["message"] = isEn ? "Employee Data not found." : "查無此員工";
                return View();
            } 
        }

        /// <summary>
        /// 撈取DB資料
        /// </summary>
        /// <param name="strid">員工編號</param>
        /// <returns></returns>
        public List<IDcard> ls_IDCard(string strid)
        {
            var result = new List<IDcard>();
            using (Model1 db1 = new Model1())
            {
                var empdata = (from c in db1.F22cmmEmpData
                               where c.Fno == strid
                               select c).ToList();
                var dep = (from d in db1.F22cmmDep
                           select d).ToList();
                var title = (from e in db1.F22cmmTitle
                             select e).ToList();
                var rs1 = (from o in empdata
                         from p in dep
                         where o.DCode == p.DCode
                         select new IDcard
                         {
                             Fno = o.Fno,
                             Name = o.Name,
                             En_Name = o.En_Name,
                             DName = p.DName,
                             En_DName = p.En_DName,
                             TCode = o.TCode_Display,
                             UseQuit = o.UseQuit,
                             EMail = o.EMail,
                             Telext = o.Telext,
                             Fax = o.Fax,
                             Mobile = o.Mobile,
                             Tel = o.Tel,
                             Hotline = o.Hotline,
                         }).ToList();
                var rs2 = (from o in rs1
                          from p in title
                          where o.TCode == p.TCode
                          select new IDcard
                          {
                              Fno = o.Fno,
                              Name = o.Name,
                              En_Name = o.En_Name == null ? "" : o.En_Name.Replace(',',' '),
                              DName = o.DName,
                              En_DName = o.En_DName,
                              TCode = o.TCode,
                              Title = p.Title,
                              En_Title = p.En_Title,
                              UseQuit = o.UseQuit,
                              EMail = o.EMail,
                              Telext = o.Telext,
                              Fax = o.Fax,
                              Mobile = o.Mobile == null ? (o.Mobile == "" ? "": o.Mobile) : o.Mobile,
                              Tel = o.Tel,
                              Hotline = o.Hotline,
                          }).FirstOrDefault();
                result.Add(rs2);
            }
            return result;
        }

        /// <summary>
        /// 產生QRcode暫存在區域變數
        /// </summary>
        /// <param name="strDesEnCode"></param>
        public void GerenateQRCdoe(string token)
        {
            var writer = new BarcodeWriter  //dll裡面可以看到屬性
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions //設定大小
                {
                    Height = 100,
                    Width = 100,
                }
            };
            //產生QRcode ex:https://pj.ftis.org.tw/

            //20230927, add by markhong 特殊字元�
            if (token.IndexOf('�') > 0)
                token = token.Replace("�", "%dA");

            string tmpurl = _isEn ? string.Format("https://pj.ftis.org.tw/VCard/?id={0}&isEn=true", token) :
                string.Format("https://pj.ftis.org.tw/VCard/?id={0}", token);
            var img = writer.Write(tmpurl);
            Bitmap myBitmap = new Bitmap(img);
            MemoryStream ms = new MemoryStream();
            myBitmap.Save(ms, ImageFormat.Jpeg);
            _pic = ms.ToArray();
            _isQRcode = true;
        }

        /// <summary>
        /// 讀取與產生UI用QRCode
        /// </summary>
        /// <returns></returns>
        public ActionResult QrCodePhotoGet()
        {
            if (_isQRcode)
            {
                byte[] cover = _pic;
                if (cover != null)
                {
                    ViewBag.isPhoto = true;
                    return File(cover, "image/jpg");
                }
            }
            return View();
        }

        /// <summary>
        /// 產生Headshot
        /// </summary>
        /// <returns></returns>
        public ActionResult HeadshotGet()
        {
            if (_isHeadshot)
            {
                byte[] cover = GetImageFromDataBase(_token);
                if (cover != null)
                {
                    ViewBag.isPhoto = true;
                    return File(cover, "image/jpg");
                }
            }
            return View();
        }

        /// <summary>
        /// 從DB讀取QRcode資料
        /// </summary>
        /// <param name="Token"></param>
        /// <returns></returns>
        public byte[] GetImageFromDataBase(string Token)
        {
            string strDecode = Des_En_De_Code.DesDecrypt(_key, Token);
            using (Model1 db = new Model1())
            {
                var q = (from item in db.F22cmmEmpData where item.Fno == strDecode select item.Headshot).ToList();
                byte[] cover = q.First();
                return cover;
            }
        }
    }
}