namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmEmpDa5
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Fno { get; set; }

        [StringLength(10)]
        public string mno { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte sno { get; set; }

        [StringLength(80)]
        public string da501 { get; set; }

        [StringLength(50)]
        public string da502 { get; set; }

        public int? da503 { get; set; }

        [StringLength(6)]
        public string da504 { get; set; }

        [StringLength(6)]
        public string da505 { get; set; }

        [StringLength(50)]
        public string da506 { get; set; }

        [Column(TypeName = "text")]
        public string da507 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateTime { get; set; }

        [StringLength(6)]
        public string UpdateMan { get; set; }
    }
}
