namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmGrade
    {
        [Key]
        [StringLength(2)]
        public string GCode { get; set; }

        [Required]
        [StringLength(20)]
        public string Grade { get; set; }
    }
}
