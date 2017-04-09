namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.DB_SETTINGS")]
    public partial class DB_SETTINGS
    {
        [Key]
        [StringLength(50)]
        public string SETTING_CODE { get; set; }

        [StringLength(160)]
        public string VALUE { get; set; }

        [StringLength(4000)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }

        public DateTime? MODIFIED_DATE { get; set; }
    }
}
