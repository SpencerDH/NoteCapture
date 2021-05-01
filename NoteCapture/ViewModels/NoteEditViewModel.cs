using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteCapture.ViewModels
{
    public class NoteEditViewModel
    {
        public int ID { get; set; }
        public string NoteTitle { get; set; }
        public string NoteText { get; set; }
    }
}
