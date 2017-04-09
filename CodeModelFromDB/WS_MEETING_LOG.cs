namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.WS_MEETING_LOG")]
    public partial class WS_MEETING_LOG
    {
        [Key]
        [StringLength(6)]
        public string MEETING_LOG_CODE { get; set; }

        [StringLength(4000)]
        public string TEXT { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        [StringLength(50)]
        public string MEETING_CODE { get; set; }

        [StringLength(50)]
        public string PERMISSION_CODE { get; set; }

        [StringLength(500)]
        public string CREATED_BY { get; set; }

        public virtual WS_MEETINGS WS_MEETINGS { get; set; }
    }
}
