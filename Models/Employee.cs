//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Referential.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public string EDesignation { get; set; }
        public Nullable<int> ESalary { get; set; }
        public byte[] EImage { get; set; }
        public Nullable<int> DepId { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
