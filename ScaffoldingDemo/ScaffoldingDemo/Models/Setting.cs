//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScaffoldingDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Setting
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
        public string Website { get; set; }
        public string BusinessHoursWeekdays { get; set; }
        public string BusinessHoursSaturday { get; set; }
        public string BusinessHoursSunday { get; set; }
        public string ContactInfo { get; set; }
        public string ContactFormText { get; set; }
    }
}
