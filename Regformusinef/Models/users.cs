using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Regformusinef.Models
{
    public class users
    {[Key]
       public int userid { get; set; }
        [Display(Name="Name")]
        [Required(ErrorMessage ="Please enter your name!!")]
        public string Name { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Roll Number")]
        [Required(ErrorMessage ="Please enter your roll number!!")]
        public int RollNo { get; set; }
       
        [Display(Name = "Branch")]
        [Required(ErrorMessage = "Please enter your Branch!!")]
        public string Branch { get; set; }
        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Please enter your mobile number!!")]
        public int Mobile{ get; set; }
        [Display(Name = "State")]
        [Required(ErrorMessage = "Please enter your state!!")]
        public string State { get; set; }
    }
}