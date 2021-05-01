using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteCapture.Models;
using System.ComponentModel.DataAnnotations;

namespace NoteCapture.Models
{
    public class UserRegistrationModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a username")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter a valid email address")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter a password you do not use anywhere else. Passwords must match.")]
        [Display(Name = "Password")]
        public string Password1 { get; set; }

        [Required(ErrorMessage = "Please enter a password you do not use anywhere else. Passwords must match.")]
        [Display(Name = "Password")]
        public string Password2 { get; set; }
    }
}
