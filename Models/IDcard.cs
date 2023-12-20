using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FTIS_IDCARD.Models
{
    public class IDcard
    {
        public string Fno { get; set; }
        public string Mno { get; set; }
        public string Name { get; set; }
        public string En_Name { get; set; }
        public string DCode_ { get; set; }
        public string DName { get; set; }
        public string En_DName { get; set; }
        public string TCode { get; set; }
        public string Title { get; set; }
        public string En_Title { get; set; }
        public bool Quit { get; set; }
        public string UseQuit { get; set; }
        public string EMail { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Tel { get; set; }
        public string Telext { get; set; }
        public string Hotline { get; set; }

        //public string Fno { get; set; }
        //public string Mno { get; set; }
        //public string Name { get; set; }
        //public string Sex { get; set; }
        //public DateTime AD { get; set; }
        //public DateTime ADRest { get; set; }
        //public DateTime AD_Vacation { get; set; }
        //public DateTime? TEnddate { get; set; }
        //public string IsQuit { get; set; }
        //public bool Quit { get; set; }
        //public DateTime? QuitDate { get; set; }
        //public string DCode { get; set; }
        //public string TCode { get; set; }
        //public string GCode { get; set; }
        //public string MpCode { get; set; }
        //public string EMail { get; set; }
        //public string CkNo1 { get; set; }
        //public string CkNo2 { get; set; }
        //public string CkNo3 { get; set; }
        //public string CkNo4 { get; set; }
        //public string CkNo5 { get; set; }
        //public string AgentNo { get; set; }
        //public string kpino1 { get; set; }
        //public string kpino2 { get; set; }
        //public string kpino3 { get; set; }
        //public string kpino4 { get; set; }
        //public string kpino5 { get; set; }
        //public string UseQuit { get; set; }
        //public bool? QuitYN { get; set; }
        //public string QuitNo { get; set; }
        //public string UseTrainning { get; set; }
        //public bool? eryn { get; set; }
        //public string IsOT2V { get; set; }
        //public DateTime? UpdateTime { get; set; }
        //public string UpdateMan { get; set; }
        //public string DCode_ { get; set; }
    }
}