using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Writely.Data;
using Writely.Models;

namespace Writely.Controllers
{
    public class PrijavaKorisnikaController : Controller
    {
        private readonly WritelyDbContext _context;

        public PrijavaKorisnikaController(WritelyDbContext context)
        {
            _context = context;
        }

        // GET: PrijavaKorisnika
        public async Task<IActionResult> Index()
        {
            var writelyDbContext = _context.PrijavaKorisnika.Include(p => p.Pošiljalac);
            return View(await writelyDbContext.ToListAsync());
        }

        // GET: PrijavaKorisnika/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavaKorisnika = await _context.PrijavaKorisnika
                .Include(p => p.Pošiljalac)
                .FirstOrDefaultAsync(m => m.id == id);
            if (prijavaKorisnika == null)
            {
                return NotFound();
            }

            return View(prijavaKorisnika);
        }

        // GET: PrijavaKorisnika/Create
        public IActionResult Create()
        {
            ViewData["PošiljalacId"] = new SelectList(_context.Korisnik, "id", "ImePrezime");
            return View();
        }

        // POST: PrijavaKorisnika/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Naziv,Sadržaj,PošiljalacId,StatusId,DatumPrijave,PrijavaId,KorisnikId")] PrijavaKorisnika prijavaKorisnika)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prijavaKorisnika);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PošiljalacId"] = new SelectList(_context.Korisnik, "id", "ImePrezime", prijavaKorisnika.PošiljalacId);
            return View(prijavaKorisnika);
        }

        // GET: PrijavaKorisnika/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavaKorisnika = await _context.PrijavaKorisnika.FindAsync(id);
            if (prijavaKorisnika == null)
            {
                return NotFound();
            }
            ViewData["PošiljalacId"] = new SelectList(_context.Korisnik, "id", "ImePrezime", prijavaKorisnika.PošiljalacId);
            return View(prijavaKorisnika);
        }

        // POST: PrijavaKorisnika/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Naziv,Sadržaj,PošiljalacId,StatusId,DatumPrijave,PrijavaId,KorisnikId")] PrijavaKorisnika prijavaKorisnika)
        {
            if (id != prijavaKorisnika.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prijavaKorisnika);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrijavaKorisnikaExists(prijavaKorisnika.id))
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
            ViewData["PošiljalacId"] = new SelectList(_context.Korisnik, "id", "ImePrezime", prijavaKorisnika.PošiljalacId);
            return View(prijavaKorisnika);
        }

        // GET: PrijavaKorisnika/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavaKorisnika = await _context.PrijavaKorisnika
                .Include(p => p.Pošiljalac)
                .FirstOrDefaultAsync(m => m.id == id);
            if (prijavaKorisnika == null)
            {
                return NotFound();
            }

            return View(prijavaKorisnika);
        }

        // POST: PrijavaKorisnika/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prijavaKorisnika = await _context.PrijavaKorisnika.FindAsync(id);
            _context.PrijavaKorisnika.Remove(prijavaKorisnika);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrijavaKorisnikaExists(int id)
        {
            return _context.PrijavaKorisnika.Any(e => e.id == id);
        }
    }
}
