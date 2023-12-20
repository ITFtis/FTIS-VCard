namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22VacationRule
    {
        [Key]
        public byte VID { get; set; }

        public short? Aseniority { get; set; }

        [StringLength(6)]
        public string Vunit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VAPquantity { get; set; }
    }
}
