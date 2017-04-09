namespace CodeModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMITTEES_CUSTOM.WS_USERS")]
    public partial class WS_USERS
    {
        [Key]
        [StringLength(50)]
        public string USERNAME { get; set; }

        [StringLength(1000)]
        public string NAME { get; set; }

        [StringLength(1000)]
        public string NAME_ARABIC { get; set; }

        [StringLength(50)]
        public string BANNER_ID { get; set; }

        [StringLength(50)]
        public string STATUS { get; set; }

        [StringLength(50)]
        public string ORG_CODE { get; set; }

        [StringLength(1000)]
        public string ORG_TITLE_ENG { get; set; }

        [StringLength(1000)]
        public string ORG_TITLE_ARA { get; set; }

        [StringLength(50)]
        public string POSN_NO { get; set; }

        [StringLength(1000)]
        public string POSN_TITLE_ENG { get; set; }

        [StringLength(1000)]
        public string POSN_TITLE_ARA { get; set; }

        [StringLength(50)]
        public string GRADE { get; set; }
    }
}
