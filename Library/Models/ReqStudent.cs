//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReqStudent
    {
        public int CustID { get; set; }
        public long Isbn { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Subject { get; set; }
        public string Type { get; set; }
        public string AuthName { get; set; }
        public string ReqConfirmation { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
