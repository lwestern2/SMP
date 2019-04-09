using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;
using SacramentMeetingPlanner.Data;


namespace SacramentMeetingPlanner.Controllers
{
    public class SacramentsController : Controller
    {
        private readonly SacramentMeetingContext _context;

        public SacramentsController(SacramentMeetingContext context)
        {
            _context = context;
        }

        // GET: Sacraments
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
            ViewData["CurrentFilter"] = searchString;

            var meeting = from s in _context.Sacrament
                         select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                meeting = meeting.Where(s => s.OpeningHymn.Contains(searchString)
                                       || s.IntermediateHymn.Contains(searchString)
                                       || s.ClosingHymn.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "date_desc":
                    meeting = meeting.OrderByDescending(s => s.MeetingDate);
                    break;
                default:
                    meeting = meeting.OrderBy(s => s.MeetingDate);
                    break;
            }
            return View(await meeting.AsNoTracking().ToListAsync());
        }

        // GET: Sacraments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacrament = await _context.Sacrament
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sacrament == null)
            {
                return NotFound();
            }

            return View(sacrament);
        }

        // GET: Sacraments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sacraments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MeetingDate,MeetingDateString,OpeningHymn,IntermediateHymn,ClosingHymn")] Sacrament sacrament)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sacrament);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sacrament);
        }

        // GET: Sacraments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacrament = await _context.Sacrament.FindAsync(id);
            if (sacrament == null)
            {
                return NotFound();
            }
            return View(sacrament);
        }

        // POST: Sacraments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MeetingDate,MeetingDateString,OpeningHymn,IntermediateHymn,ClosingHymn")] Sacrament sacrament)
        {
            if (id != sacrament.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sacrament);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SacramentExists(sacrament.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sacrament);
        }

        // GET: Sacraments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacrament = await _context.Sacrament
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sacrament == null)
            {
                return NotFound();
            }

            return View(sacrament);
        }

        // POST: Sacraments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sacrament = await _context.Sacrament.FindAsync(id);
            _context.Sacrament.Remove(sacrament);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SacramentExists(int id)
        {
            return _context.Sacrament.Any(e => e.ID == id);
        }
    }
}
