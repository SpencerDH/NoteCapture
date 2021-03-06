using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteCapture.Models
{
    public class Note
    {
        // Properties
        public int ID { get; set; }
        public string NoteTitle { get; set; }
        public string NoteText { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated { get; set; }
        public bool InTrash { get; set; }

        // Navigation properties
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }
        public List<Tag> Tags { get; set; }

        public Note()
        {
            TimeCreated = DateTime.Now;
            TimeUpdated = TimeCreated;
            NoteText = "";
            NoteTitle = "Untitled";
            InTrash = false;
        }
    }
}
