namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22VAPFlowStatus
    {
        [Key]
        public byte StatusID { get; set; }

        [StringLength(10)]
        public string Status { get; set; }
    }
}
