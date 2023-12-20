namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmEmpDa8
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
        public string da801 { get; set; }

        [StringLength(6)]
        public string da802 { get; set; }

        [StringLength(50)]
        public string da803 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateTime { get; set; }

        [StringLength(6)]
        public string UpdateMan { get; set; }
    }
}
