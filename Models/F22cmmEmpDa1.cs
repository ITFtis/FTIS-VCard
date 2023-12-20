namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmEmpDa1
    {
        [Key]
        [StringLength(6)]
        public string Fno { get; set; }

        [StringLength(10)]
        public string mno { get; set; }

        [StringLength(40)]
        public string da01 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? da03 { get; set; }

        [StringLength(10)]
        public string da04 { get; set; }

        [StringLength(10)]
        public string da05 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? da06 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? da07 { get; set; }

        [StringLength(2)]
        public string da08 { get; set; }

        [StringLength(3)]
        public string da09 { get; set; }

        [StringLength(100)]
        public string da10 { get; set; }

        [StringLength(3)]
        public string da11a { get; set; }

        [StringLength(8)]
        public string da11 { get; set; }

        [StringLength(3)]
        public string da12 { get; set; }

        [StringLength(100)]
        public string da13 { get; set; }

        [StringLength(3)]
        public string da14a { get; set; }

        [StringLength(8)]
        public string da14 { get; set; }

        [StringLength(10)]
        public string da15 { get; set; }

        [StringLength(20)]
        public string da17 { get; set; }

        [StringLength(6)]
        public string da18 { get; set; }

        [StringLength(10)]
        public string da19 { get; set; }

        [StringLength(20)]
        public string da20 { get; set; }

        [StringLength(6)]
        public string da21 { get; set; }

        [StringLength(10)]
        public string da22 { get; set; }

        [StringLength(50)]
        public string da23 { get; set; }

        [StringLength(500)]
        public string da24 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateTime { get; set; }

        [StringLength(6)]
        public string Updateman { get; set; }
    }
}
