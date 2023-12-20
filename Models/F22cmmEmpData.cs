namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmEmpData
    {
        [Key]
        [StringLength(6)]
        public string Fno { get; set; }

        [Required]
        [StringLength(6)]
        public string Mno { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(50)]
        public string En_Name { get; set; }

        [Required]
        [StringLength(2)]
        public string Sex { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime AD { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ADRest { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime AD_Vacation { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TEnddate { get; set; }

        [Required]
        [StringLength(1)]
        public string IsQuit { get; set; }

        public bool Quit { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? QuitDate { get; set; }

        [Required]
        [StringLength(2)]
        public string DCode { get; set; }

        [Required]
        [StringLength(2)]
        public string TCode { get; set; }

        public string TCode_Display { get; set; }

        [Required]
        [StringLength(2)]
        public string GCode { get; set; }

        [StringLength(1)]
        public string MpCode { get; set; }

        [Required]
        [StringLength(150)]
        public string EMail { get; set; }

        [Required]
        [StringLength(6)]
        public string CkNo1 { get; set; }

        [StringLength(6)]
        public string CkNo2 { get; set; }

        [StringLength(6)]
        public string CkNo3 { get; set; }

        [StringLength(6)]
        public string CkNo4 { get; set; }

        [StringLength(6)]
        public string CkNo5 { get; set; }

        [StringLength(6)]
        public string AgentNo { get; set; }

        [Required]
        [StringLength(6)]
        public string kpino1 { get; set; }

        [StringLength(6)]
        public string kpino2 { get; set; }

        [StringLength(6)]
        public string kpino3 { get; set; }

        [StringLength(6)]
        public string kpino4 { get; set; }

        [StringLength(6)]
        public string kpino5 { get; set; }

        [StringLength(1)]
        public string UseQuit { get; set; }

        public bool? QuitYN { get; set; }

        [StringLength(7)]
        public string QuitNo { get; set; }

        [Required]
        [StringLength(1)]
        public string UseTrainning { get; set; }

        public bool? eryn { get; set; }

        [StringLength(1)]
        public string IsOT2V { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }

        [StringLength(10)]
        public string Telext { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        [StringLength(20)]
        public string Hotline { get; set; }

        [Column(TypeName = "image")]
        public byte[] Headshot { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateTime { get; set; }

        [StringLength(6)]
        public string UpdateMan { get; set; }

        [StringLength(2)]
        public string DCode_ { get; set; }
    }
}
