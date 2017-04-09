namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.WS_COMMITTEES")]
    public partial class WS_COMMITTEES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WS_COMMITTEES()
        {
            WS_COMMITTEE_CATEGORIES = new HashSet<WS_COMMITTEE_CATEGORIES>();
            WS_COMMITTEE_PERMISSIONS = new HashSet<WS_COMMITTEE_PERMISSIONS>();
            WS_MEETINGS = new HashSet<WS_MEETINGS>();
        }

        [Key]
        [StringLength(50)]
        public string COMMITTEE_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string TITLE { get; set; }

        [StringLength(1000)]
        public string DESCRIPTION { get; set; }

        [StringLength(50)]
        public string ADMIN { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime CREATED_DATE { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }

        public DateTime? MODIFIED_DATE { get; set; }

        [StringLength(1000)]
        public string REMARKS { get; set; }

        [StringLength(50)]
        public string LANGUAGE { get; set; }

        [StringLength(50)]
        public string TITLE_ARABIC { get; set; }

        [StringLength(1000)]
        public string DESCRIPTION_ARABIC { get; set; }

        [StringLength(50)]
        public string STATUS { get; set; }

        public decimal? MEETING_NUMBER_START { get; set; }

        [StringLength(50)]
        public string FINAL_APPROVAL_REQUIRED { get; set; }

        [StringLength(50)]
        public string REVIEW_REQUIRED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_COMMITTEE_CATEGORIES> WS_COMMITTEE_CATEGORIES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_COMMITTEE_PERMISSIONS> WS_COMMITTEE_PERMISSIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_MEETINGS> WS_MEETINGS { get; set; }
    }
}
