namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22MamWTrecord
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string Mno { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime CT { get; set; }

        [StringLength(10)]
        public string CardNo { get; set; }

        public short? DoorNo { get; set; }

        [StringLength(10)]
        public string Ttype { get; set; }
    }
}
