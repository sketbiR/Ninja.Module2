namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.WS_ROLES")]
    public partial class WS_ROLES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WS_ROLES()
        {
            WS_COMMITTEE_PERMISSIONS = new HashSet<WS_COMMITTEE_PERMISSIONS>();
        }

        [Key]
        [StringLength(50)]
        public string ROLE_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string TITLE { get; set; }

        [StringLength(50)]
        public string TITLE_ARABIC { get; set; }

        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }

        public DateTime? MODIFIED_DATE { get; set; }

        [StringLength(1000)]
        public string REMARKS { get; set; }

        [StringLength(1000)]
        public string DESCRIPTION_ARABIC { get; set; }

        [StringLength(1000)]
        public string DESCRIPTION { get; set; }

        [StringLength(50)]
        public string ABBREVIATION { get; set; }

        [StringLength(50)]
        public string ATTEND_MEETING { get; set; }

        [StringLength(50)]
        public string DISPLAY_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_COMMITTEE_PERMISSIONS> WS_COMMITTEE_PERMISSIONS { get; set; }
    }
}
