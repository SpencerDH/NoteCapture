using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace NoteCapture.Models
{
    public class AppUser : IdentityUser
    {
        // Properties
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        // Navigation properties
        public IEnumerable<Note> Notes { get; set; }
    }
}
