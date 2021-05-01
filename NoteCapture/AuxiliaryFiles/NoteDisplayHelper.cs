using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteCapture.Models;
using NoteCapture.ViewModels;

namespace NoteCapture.AuxiliaryFiles
{
    public class NoteDisplayHelper
    {
        public NoteDisplayHelper()
        {

        }

        public string Abbreviator(string noteText)
        {
            string abbrevText = noteText.Substring(0, Math.Min(noteText.Length, 15));
            return abbrevText;
        }

        public NotesIndexViewModel CreateViewModel(Note note)
        {
            NotesIndexViewModel viewModel = new NotesIndexViewModel
            {
                NoteID = note.ID,
                NoteTextAbbreviation = Abbreviator(note.NoteText),
                TimeCreated = note.TimeCreated
            };

            return viewModel;
        }
    }
}
