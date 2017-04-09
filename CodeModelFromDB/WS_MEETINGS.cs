namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.WS_MEETINGS")]
    public partial class WS_MEETINGS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WS_MEETINGS()
        {
            WS_ATTENDEES = new HashSet<WS_ATTENDEES>();
            WS_MEETING_ITEMS = new HashSet<WS_MEETING_ITEMS>();
            WS_MEETING_LOG = new HashSet<WS_MEETING_LOG>();
        }

        [Key]
        [StringLength(50)]
        public string MEETING_CODE { get; set; }

        public decimal MEETING_NUMBER { get; set; }

        public decimal? MEETING_YEAR { get; set; }

        [StringLength(50)]
        public string STATUS { get; set; }

        public DateTime MEETING_DATE_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string LOCATION { get; set; }

        [StringLength(50)]
        public string COMMITTEE_APPROVAL { get; set; }

        [StringLength(50)]
        public string FINAL_APPROVAL { get; set; }

        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }

        public DateTime? MODIFIED_DATE { get; set; }

        [Required]
        [StringLength(50)]
        public string COMMITTEE_CODE { get; set; }

        [StringLength(1000)]
        public string REMARKS { get; set; }

        [StringLength(500)]
        public string START_TIME { get; set; }

        [StringLength(500)]
        public string END_TIME { get; set; }

        [StringLength(50)]
        public string FINAL_APPROVER_CODE { get; set; }

        [StringLength(50)]
        public string REVIEWER_CODE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_ATTENDEES> WS_ATTENDEES { get; set; }

        public virtual WS_COMMITTEE_PERMISSIONS WS_COMMITTEE_PERMISSIONS { get; set; }

        public virtual WS_COMMITTEE_PERMISSIONS WS_COMMITTEE_PERMISSIONS1 { get; set; }

        public virtual WS_COMMITTEES WS_COMMITTEES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_MEETING_ITEMS> WS_MEETING_ITEMS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_MEETING_LOG> WS_MEETING_LOG { get; set; }
    }
}
