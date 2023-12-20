namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmTitle
    {
        [Key]
        [StringLength(2)]
        public string TCode { get; set; }

        [Required]
        [StringLength(20)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string En_Title { get; set; }
    }
}
