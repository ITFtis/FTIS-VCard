namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmEmpDa6
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

        [StringLength(20)]
        public string da601 { get; set; }

        [StringLength(20)]
        public string da602 { get; set; }

        [StringLength(8)]
        public string da603 { get; set; }

        [StringLength(50)]
        public string da604 { get; set; }

        [StringLength(100)]
        public string da605 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateTime { get; set; }

        [StringLength(20)]
        public string UpdateMan { get; set; }
    }
}
