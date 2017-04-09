namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.WS_ITEM_FILES")]
    public partial class WS_ITEM_FILES
    {
        [Key]
        [StringLength(50)]
        public string ITEM_FILE_CODE { get; set; }

        public byte[] FILE_BLOB { get; set; }

        [StringLength(50)]
        public string MEETING_ITEM_CODE { get; set; }

        [StringLength(1000)]
        public string CREATED_BY { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        [StringLength(1000)]
        public string MODIFIED_BY { get; set; }

        public DateTime? MODIFIED_DATE { get; set; }

        public virtual WS_MEETING_ITEMS WS_MEETING_ITEMS { get; set; }
    }
}
