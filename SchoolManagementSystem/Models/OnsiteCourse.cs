//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OnsiteCourse
    {
        public int CourseID { get; set; }
        public string Location { get; set; }
        public string Days { get; set; }
        public System.DateTime Time { get; set; }
    
        public virtual Course Course { get; set; }
    }
}
