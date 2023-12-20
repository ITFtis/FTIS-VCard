namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmEmpDa4
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Fno { get; set; }

        [StringLength(6)]
        public string mno { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte sno { get; set; }

        [StringLength(50)]
        public string da401 { get; set; }

        [StringLength(20)]
        public string da402 { get; set; }

        [StringLength(50)]
        public string da403 { get; set; }

        [StringLength(6)]
        public string da404 { get; set; }

        [StringLength(6)]
        public string da405 { get; set; }

        [StringLength(6)]
        public string da406 { get; set; }

        [StringLength(20)]
        public string da407 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateTime { get; set; }

        [StringLength(6)]
        public string UpdateMan { get; set; }
    }
}
