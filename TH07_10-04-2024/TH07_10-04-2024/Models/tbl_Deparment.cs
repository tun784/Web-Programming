//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TH07_10_04_2024.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Deparment
    {
        public tbl_Deparment()
        {
            this.tbl_Employee = new HashSet<tbl_Employee>();
        }
    
        public int DeptId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<tbl_Employee> tbl_Employee { get; set; }
    }
}
