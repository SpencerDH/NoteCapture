using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteCapture.Models
{
    public class Tag
    {
        // Properties
        public int ID { get; set; }
        public string TagName { get; set; }

        // Navigation properties
        public int NoteID { get; set; }
        public Note Note { get; set; }
    }
}
