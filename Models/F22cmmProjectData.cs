namespace FTIS_IDCARD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F22cmmProjectData
    {
        [StringLength(9)]
        public string PrjID { get; set; }

        [Key]
        [StringLength(10)]
        public string PjNo { get; set; }

        [Required]
        [StringLength(100)]
        public string PrjName { get; set; }

        [StringLength(20)]
        public string BriefName { get; set; }

        [Required]
        [StringLength(1)]
        public string Status { get; set; }

        [StringLength(50)]
        public string OwnerA { get; set; }

        [StringLength(50)]
        public string OwnerB { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PrjStartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PrjEndDate { get; set; }

        [Required]
        [StringLength(6)]
        public string CkNo1 { get; set; }

        [StringLength(10)]
        public string CkName1 { get; set; }

        [StringLength(6)]
        public string CkNo2 { get; set; }

        [StringLength(10)]
        public string CkName2 { get; set; }

        [StringLength(6)]
        public string CkNo3 { get; set; }

        [StringLength(10)]
        public string CkName3 { get; set; }

        [StringLength(6)]
        public string CkNo4 { get; set; }

        [StringLength(10)]
        public string CkName4 { get; set; }

        [StringLength(1)]
        public string IsClosed { get; set; }

        public bool PjClose { get; set; }

        [StringLength(1)]
        public string PCheck { get; set; }

        [StringLength(1)]
        public string HDYOT { get; set; }

        [StringLength(1)]
        public string ckrpt { get; set; }

        [StringLength(20)]
        public string PjNoM { get; set; }

        [StringLength(100)]
        public string PjNameM { get; set; }

        [StringLength(1)]
        public string PjUseM { get; set; }
    }
}
