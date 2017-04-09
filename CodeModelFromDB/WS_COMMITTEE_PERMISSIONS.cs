namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.WS_COMMITTEE_PERMISSIONS")]
    public partial class WS_COMMITTEE_PERMISSIONS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WS_COMMITTEE_PERMISSIONS()
        {
            WS_ATTENDEES = new HashSet<WS_ATTENDEES>();
            WS_MEETINGS = new HashSet<WS_MEETINGS>();
            WS_MEETINGS1 = new HashSet<WS_MEETINGS>();
        }

        [Key]
        [StringLength(50)]
        public string PERMISSIONS_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(50)]
        public string STATUS { get; set; }

        public decimal? DISPLAY_ORDER { get; set; }

        [Required]
        [StringLength(50)]
        public string ROLE_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string COMMITTEE_CODE { get; set; }

        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }

        [StringLength(50)]
        public string MODIFIED_DATE { get; set; }

        [StringLength(1000)]
        public string REMARKS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_ATTENDEES> WS_ATTENDEES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_MEETINGS> WS_MEETINGS { get; set; }

        public virtual WS_ROLES WS_ROLES { get; set; }

        public virtual WS_COMMITTEES WS_COMMITTEES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WS_MEETINGS> WS_MEETINGS1 { get; set; }
    }
}
