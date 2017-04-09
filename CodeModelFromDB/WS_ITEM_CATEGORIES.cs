namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.WS_ITEM_CATEGORIES")]
    public partial class WS_ITEM_CATEGORIES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WS_ITEM_CATEGORIES()
        {
            WS_COMMITTEE_CATEGORIES = new HashSet<WS_COMMITTEE_CATEGORIES>();
        }

        [Key]
        [StringLength(50)]
        public string ITEM_CATEGORY_CODE { get; set; }

        [StringLength(50)]
        public string TITLE { get; set; }

        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }

        public DateTime? MODIFIED_DATE { get; set; }

        [StringLength(1000)]
        public string REMARKS { get; set; }

        [StringLength(50)]
        public string TITLE_ARABIC { get; set; }

        [StringLength(50)]
        public string ABBREVIATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_COMMITTEE_CATEGORIES> WS_COMMITTEE_CATEGORIES { get; set; }
    }
}
