using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteCapture.Models;
using NoteCapture.Data;
using Microsoft.EntityFrameworkCore;
using NoteCapture.ViewModels;
using Microsoft.AspNetCore.Identity;
using NoteCapture.AuxiliaryFiles;
using Newtonsoft.Json;

namespace NoteCapture.Controllers
{
    public class NotesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public NotesController(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            // Get current user ID, and select only notes associated with that user
            var currentUser = await _userManager.GetUserAsync(User);
            var currentUserId = currentUser.Id;

            var notesList = await _context.Notes
                .Where(n => n.AppUserId == currentUserId)
                .Where(n => n.InTrash == false)
                .ToListAsync();

            // Initialize NoteDisplayHelper object
            NoteDisplayHelper helper = new NoteDisplayHelper();

            return View(notesList);
        }

        [HttpPost]
        public async Task<JsonResult> AjaxTest(NoteEditViewModel noteEdit)
        {
            // Extract the values passed through the viewmodel
            int viewModelID = noteEdit.ID;
            string viewModelNoteTitle = noteEdit.NoteTitle;
            string viewModelNoteText = noteEdit.NoteText;

            // Get current user ID to make sure that the user is authorized to edit this note
            var currentUser = await _userManager.GetUserAsync(User);
            var currentUserId = currentUser.Id;

            // Get the note corresponding to the ID passed to the controller from the database
            var note = await _context.Notes
                .Where(n => n.AppUserId == currentUserId)
                .Where(n => n.InTrash == false)
                .FirstOrDefaultAsync(n => n.ID == viewModelID);

            // If the note doesn't exist, return the user to the Notes index
            if (note == null)
            {
                // Need to add error handling here
                Console.WriteLine("Note doesn't exist");
            }

            // hhall@projectriskcoach.com

            // If the note does exist, add the edits and save
            note.NoteTitle = viewModelNoteTitle;
            note.NoteText = viewModelNoteText;
            _context.Update(note);
            await _context.SaveChangesAsync();

            // Return JSON object
            return Json(new { noteID = noteEdit.ID, noteText = noteEdit.NoteText, noteTitle = noteEdit.NoteTitle });
        }

        public async Task<IActionResult> Create()
        {
            // Get current user
            var currentUser = await _userManager.GetUserAsync(User);

            // Create new note and assign AppUser property
            Note newNote = new Note
            {
                AppUser = currentUser,
                AppUserId = currentUser.Id
            };

            // Save the new note to the database, and return user to the notes page
            _context.Add(newNote);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Notes");
        }

        public async Task<IActionResult> Edit(NoteEditViewModel noteEdit)
        {
            // Extract the values passed through the viewmodel
            int viewModelID = noteEdit.ID;
            string viewModelNoteTitle = noteEdit.NoteTitle;
            string viewModelNoteText = noteEdit.NoteText;

            // Get current user ID to make sure that the user is authorized to edit this note
            var currentUser = await _userManager.GetUserAsync(User);
            var currentUserId = currentUser.Id;

            // Get the note corresponding to the ID passed to the controller from the database
            var note = await _context.Notes
                .Where(n => n.AppUserId == currentUserId)
                .Where(n => n.InTrash == false)
                .FirstOrDefaultAsync(n => n.ID == viewModelID);

            // If the note doesn't exist, return the user to the Notes index
            if (note == null)
            {
                return RedirectToAction("Index", "Notes");
            }

            // If the note does exist, add the edits and save
            note.NoteTitle = viewModelNoteTitle;
            note.NoteText = viewModelNoteText;
            _context.Update(note);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Notes");
        }

        public async Task<IActionResult> Search(string searchTerm)
        {
            // Get current user ID, and select only notes associated with that user
            var currentUser = await _userManager.GetUserAsync(User);
            var currentUserId = currentUser.Id;

            var notesList = await _context.Notes
                .Where(n => n.AppUserId == currentUserId)
                .Where(n => n.NoteText.Contains(searchTerm) || n.NoteTitle.Contains(searchTerm))
                .Where(n => n.InTrash == false)
                .ToListAsync();

            return View(notesList);
        }

        public async Task<IActionResult> TrashIndex()
        {
            // Get current user ID, and select only notes associated with that user
            var currentUser = await _userManager.GetUserAsync(User);
            var currentUserId = currentUser.Id;

            var notesList = await _context.Notes
                .Where(n => n.AppUserId == currentUserId)
                .Where(n => n.InTrash == true)
                .ToListAsync();

            return View(notesList);
        }

        public async Task<IActionResult> MoveToTrash(int NoteTrashID)
        {
            // Get current user ID, and select only notes associated with that user
            var currentUser = await _userManager.GetUserAsync(User);
            var currentUserId = currentUser.Id;

            var note = await _context.Notes
                .Where(n => n.AppUserId == currentUserId)
                .Where(n => n.InTrash == false)
                .FirstOrDefaultAsync(n => n.ID == NoteTrashID);

            if (note != null)
            {
                note.InTrash = true;
                _context.Update(note);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Notes");
        }
    }
}
