namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.DEPARTMENTS_VW")]
    public partial class DEPARTMENTS_VW
    {
        [StringLength(15)]
        public string ORG_CODE { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(35)]
        public string ORG_NAME_ENG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string ORG_NAME_ARA { get; set; }

        [StringLength(3)]
        public string ORG_PARENT_CODE { get; set; }
    }
}
