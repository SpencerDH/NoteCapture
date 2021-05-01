using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteCapture.Models;

namespace NoteCapture.ViewModels
{
    public class NotesIndexViewModel
    {
        public int NoteID { get; set; }
        public string NoteTextAbbreviation { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}
