namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmCounty
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string CountyID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string CID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string CountyCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string CountyName { get; set; }
    }
}
