namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.WS_HR_ITEMS")]
    public partial class WS_HR_ITEMS
    {
        [Key]
        [StringLength(50)]
        public string HR_ITEM_CODE { get; set; }

        [StringLength(50)]
        public string DEPT_ORG_CODE { get; set; }

        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }

        public DateTime? MODIFIED_DATE { get; set; }

        [StringLength(50)]
        public string MEETING_ITEM_CODE { get; set; }

        [StringLength(1000)]
        public string REMARKS { get; set; }

        [StringLength(100)]
        public string EMPLOYEE_BANNER_ID { get; set; }

        [StringLength(1000)]
        public string EMPLOYEE_NAME { get; set; }

        [StringLength(1000)]
        public string EMPLOYEE_JOB_TITLE { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_GRADE { get; set; }

        [StringLength(50)]
        public string DEPT_CODE { get; set; }

        public virtual WS_MEETING_ITEMS WS_MEETING_ITEMS { get; set; }
    }
}
