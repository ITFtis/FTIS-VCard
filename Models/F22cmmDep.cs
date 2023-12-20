namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmDep
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string DCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string DName { get; set; }

        [StringLength(50)]
        public string En_DName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string Dnickname { get; set; }

        [StringLength(6)]
        public string DCkNo1 { get; set; }

        [StringLength(6)]
        public string DCkNo2 { get; set; }

        [StringLength(6)]
        public string DCkNo3 { get; set; }

        [StringLength(6)]
        public string DAdmino { get; set; }

        [StringLength(6)]
        public string DCkTopNo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string IsUsed { get; set; }

        [StringLength(2)]
        public string DCode_ { get; set; }
    }
}
