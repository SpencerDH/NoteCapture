﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoteCapture.Data;
using NoteCapture.Models;

namespace NoteCapture.ViewComponents
{
    public class NoteCardsViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public NoteCardsViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
