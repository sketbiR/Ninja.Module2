namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.WS_COMMITTEE_CATEGORIES")]
    public partial class WS_COMMITTEE_CATEGORIES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WS_COMMITTEE_CATEGORIES()
        {
            WS_MEETING_ITEMS = new HashSet<WS_MEETING_ITEMS>();
        }

        [Key]
        [StringLength(50)]
        public string COMMITTEE_CATEGORY_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public decimal? DISPLAY_ORDER { get; set; }

        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }

        public DateTime? MODIFIED_DATE { get; set; }

        [Required]
        [StringLength(50)]
        public string COMMITTEE_CODE { get; set; }

        [StringLength(50)]
        public string ITEM_CATEGORY { get; set; }

        [StringLength(1000)]
        public string REMARKS { get; set; }

        public virtual WS_COMMITTEES WS_COMMITTEES { get; set; }

        public virtual WS_ITEM_CATEGORIES WS_ITEM_CATEGORIES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_MEETING_ITEMS> WS_MEETING_ITEMS { get; set; }
    }
}
