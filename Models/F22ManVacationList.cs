namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22ManVacationList
    {
        [Key]
        [Column(Order = 0)]
        public int FtisID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string mno { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte VID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Vstartdate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Venddate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Used { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte Extend { get; set; }
    }
}
