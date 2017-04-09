namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.WS_STATUSES")]
    public partial class WS_STATUSES
    {
        [Key]
        [StringLength(50)]
        public string STATUS_CODE { get; set; }

        [StringLength(500)]
        public string TITLE { get; set; }

        [StringLength(500)]
        public string TITLE_ARABIC { get; set; }

        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }

        public DateTime? MODIFIED_DATE { get; set; }
    }
}
