namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.WS_MEETING_ITEMS")]
    public partial class WS_MEETING_ITEMS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WS_MEETING_ITEMS()
        {
            WS_HR_ITEMS = new HashSet<WS_HR_ITEMS>();
            WS_ITEM_FILES = new HashSet<WS_ITEM_FILES>();
            WS_OTHER_ITEMS = new HashSet<WS_OTHER_ITEMS>();
        }

        [Key]
        [StringLength(50)]
        public string MEETING_ITEM_CODE { get; set; }

        [StringLength(50)]
        public string COMMITTEE_APPROVAL { get; set; }

        [StringLength(50)]
        public string COMMITTEE_RECOMMENDATION { get; set; }

        [StringLength(4000)]
        public string REVIEWER_REMARKS { get; set; }

        [StringLength(50)]
        public string FINAL_APPROVAL { get; set; }

        [StringLength(50)]
        public string STATUS { get; set; }

        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }

        public DateTime? MODIFIED_DATE { get; set; }

        [StringLength(50)]
        public string CATEGORY_CODE { get; set; }

        [StringLength(50)]
        public string MEETING_CODE { get; set; }

        [StringLength(4000)]
        public string REMARKS { get; set; }

        [StringLength(4000)]
        public string REQUEST { get; set; }

        [StringLength(4000)]
        public string EXECUTE_BY { get; set; }

        public virtual WS_COMMITTEE_CATEGORIES WS_COMMITTEE_CATEGORIES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_HR_ITEMS> WS_HR_ITEMS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_ITEM_FILES> WS_ITEM_FILES { get; set; }

        public virtual WS_MEETINGS WS_MEETINGS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_OTHER_ITEMS> WS_OTHER_ITEMS { get; set; }
    }
}
