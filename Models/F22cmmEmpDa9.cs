namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmEmpDa9
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
        public string da901 { get; set; }

        [StringLength(400)]
        public string da902 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateTime { get; set; }

        [StringLength(6)]
        public string UpdateMan { get; set; }
    }
}
