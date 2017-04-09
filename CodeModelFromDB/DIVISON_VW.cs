namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.DIVISON_VW")]
    public partial class DIVISON_VW
    {
        [StringLength(15)]
        public string ORG_PARENT_CODE { get; set; }

        [Key]
        [StringLength(30)]
        public string ORG_PARENT_NAME_ENG { get; set; }

        [StringLength(200)]
        public string ORG_PARENT_NAME_ARA { get; set; }
    }
}
