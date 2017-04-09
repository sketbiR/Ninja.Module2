namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.WS_ATTENDEES")]
    public partial class WS_ATTENDEES
    {
        [Key]
        [StringLength(50)]
        public string ATTENDEE_CODE { get; set; }

        [StringLength(50)]
        public string ATTENDED { get; set; }

        [StringLength(50)]
        public string APPROVE { get; set; }

        [Required]
        [StringLength(50)]
        public string MEETING_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string COMMITTEE_PERMISSION_CODE { get; set; }

        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }

        public DateTime? MODIFIED_DATE { get; set; }

        public virtual WS_COMMITTEE_PERMISSIONS WS_COMMITTEE_PERMISSIONS { get; set; }

        public virtual WS_MEETINGS WS_MEETINGS { get; set; }
    }
}
