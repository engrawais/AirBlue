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
    
    public partial class Site
    {
        public short SiteID { get; set; }
        public string SiteName { get; set; }
        public Nullable<short> CityID { get; set; }
    
        public virtual City City { get; set; }
    }
}
