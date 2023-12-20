namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22VacationBasicData
    {
        [Key]
        [Column(Order = 0)]
        public byte VID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string VName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string VUnit { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte ClassNo { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "numeric")]
        public decimal Vnum { get; set; }

        [StringLength(255)]
        public string PayRule { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        [StringLength(200)]
        public string Attached { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string IsHrCK { get; set; }
    }
}
