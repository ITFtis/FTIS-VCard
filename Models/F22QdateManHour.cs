namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22QdateManHour
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Wyear { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte Qno { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime Wdate { get; set; }

        public byte? WeekNo { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal Class1 { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "numeric")]
        public decimal Class2 { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "numeric")]
        public decimal Class3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Class9 { get; set; }

        public byte? Daytype { get; set; }
    }
}
