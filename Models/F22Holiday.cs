namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22Holiday
    {
        [Key]
        [StringLength(8)]
        public string hday { get; set; }

        [StringLength(16)]
        public string hreason { get; set; }

        [StringLength(1)]
        public string Htype { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Hdate { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }
    }
}
