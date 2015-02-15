using System.ComponentModel;
using System.Net.Mime;
using System.Web.UI.WebControls;

namespace Purevision.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Person
    {
        public int Id { get; set; }

        //[StringLength(10)]
        //[Display(Name = "Name")]
        //public string Name { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Given", Prompt = "Given Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Surname", Prompt = "Family Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Prompt = "Email")]
        [DataType("EmailAddress")]
        public string Email { get; set; }

        [Required]
        [StringLength(14)]
        [Display(Prompt = "Phone")]
        //[DataType(DataType.PhoneNumber)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###-###-####}")]
        public string Phone { get; set; }

        [Display(Prompt = "Comments")]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        public int? UserId { get; set; }
    }
}
