namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.WS_OTHER_ITEMS")]
    public partial class WS_OTHER_ITEMS
    {
        [Key]
        [StringLength(50)]
        public string OTHER_ITEM_CODE { get; set; }

        [StringLength(500)]
        public string TITLE { get; set; }

        [StringLength(500)]
        public string REQUESTER_NAME { get; set; }

        [StringLength(50)]
        public string CREATED_BY { get; set; }

        [StringLength(50)]
        public string CREATED_DATE { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }

        [StringLength(50)]
        public string MODIFIED_DATE { get; set; }

        [StringLength(50)]
        public string MEETING_ITEM_CODE { get; set; }

        [StringLength(1000)]
        public string REMARKS { get; set; }

        public virtual WS_MEETING_ITEMS WS_MEETING_ITEMS { get; set; }
    }
}
