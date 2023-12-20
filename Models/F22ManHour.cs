namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22ManHour
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Mno { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Wyear { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte Qno { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime Wdate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NHour { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AHour { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VHour { get; set; }

        public byte? ClassID { get; set; }

        [StringLength(1)]
        public string Daytype { get; set; }

        [StringLength(1)]
        public string IsDday { get; set; }
    }
}
