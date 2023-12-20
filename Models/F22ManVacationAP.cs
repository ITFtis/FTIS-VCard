namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22ManVacationAP
    {
        [Key]
        [Column(Order = 0)]
        public long VAPNO { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime VAPdate { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string MNO { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte VID { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "smalldatetime")]
        public DateTime VAPstartdate { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smalldatetime")]
        public DateTime VAPenddate { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "numeric")]
        public decimal VAPquantity { get; set; }

        [StringLength(200)]
        public string Reason { get; set; }

        [StringLength(400)]
        public string Attached { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte Onstatus { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(6)]
        public string AgnetID { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "smalldatetime")]
        public DateTime CTime1 { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(6)]
        public string Admin21 { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(6)]
        public string Admin22 { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(6)]
        public string Admin23 { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(6)]
        public string Admin24 { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(6)]
        public string Admin25 { get; set; }

        [StringLength(6)]
        public string Admin55 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CTime21 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CTime22 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CTime23 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CTime24 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CTime25 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CTime55 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CTimeFinish { get; set; }
    }
}
