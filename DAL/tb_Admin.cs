//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_Admin
    {

        public int AdminId { get; set; }
        [Display(Name ="Admin Name")]
        [Required(ErrorMessage ="*")]
        public string AdminName { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "*")]
        public string AdminPass { get; set; }
    }
}
