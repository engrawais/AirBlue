//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ViewAuditLog
    {
        public string FormName { get; set; }
        public int AuditID { get; set; }
        public Nullable<System.DateTime> AuditDateTime { get; set; }
        public Nullable<int> AuditUserID { get; set; }
        public Nullable<short> FormID { get; set; }
        public Nullable<short> OperationID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<short> Department { get; set; }
        public string OperationName { get; set; }
    }
}
