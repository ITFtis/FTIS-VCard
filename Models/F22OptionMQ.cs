namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22OptionMQ
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
        [Column(Order = 3)]
        public byte SelectNO { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte ClassID { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smalldatetime")]
        public DateTime Cstartdate { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime Cenddate { get; set; }
    }
}
