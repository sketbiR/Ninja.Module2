//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDMXFromDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class WS_HR_ITEMS
    {
        public string HR_ITEM_CODE { get; set; }
        public string DEPT_ORG_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string MODIFIED_BY { get; set; }
        public Nullable<System.DateTime> MODIFIED_DATE { get; set; }
        public string MEETING_ITEM_CODE { get; set; }
        public string REMARKS { get; set; }
        public string EMPLOYEE_BANNER_ID { get; set; }
        public string EMPLOYEE_NAME { get; set; }
        public string EMPLOYEE_JOB_TITLE { get; set; }
        public string EMPLOYEE_GRADE { get; set; }
        public string DEPT_CODE { get; set; }
    
        public virtual WS_MEETING_ITEMS WS_MEETING_ITEMS { get; set; }
    }
}
