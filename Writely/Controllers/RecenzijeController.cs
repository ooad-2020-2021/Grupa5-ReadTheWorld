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
    public class RecenzijeController : Controller
    {
        private readonly WritelyDbContext _context;

        public RecenzijeController(WritelyDbContext context)
        {
            _context = context;
        }

        // GET: Recenzije
        public async Task<IActionResult> Index()
        {
            var writelyDbContext = _context.Recenzija.Include(r => r.Korisnik).Include(r => r.OcijenjeniRad);
            return View(await writelyDbContext.ToListAsync());
        }

        // GET: Recenzije/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recenzija = await _context.Recenzija
                .Include(r => r.Korisnik)
                .Include(r => r.OcijenjeniRad)
                .FirstOrDefaultAsync(m => m.id == id);
            if (recenzija == null)
            {
                return NotFound();
            }

            return View(recenzija);
        }

        // GET: Recenzije/Create
        public IActionResult Create()
        {
            //ViewData["KorisnikId"] = new SelectList(_context.Korisnik, "id", "ImePrezime");
            //ViewData["RadId"] = new SelectList(_context.Rad, "id", "Naziv");
            return View();
        }

        // POST: Recenzije/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ocjena,Komentar")] Recenzija recenzija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recenzija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["KorisnikId"] = new SelectList(_context.Korisnik, "id", "ImePrezime", recenzija.KorisnikId);
            //ViewData["RadId"] = new SelectList(_context.Rad, "id", "Naziv", recenzija.RadId);
            return View(recenzija);
        }

        // GET: Recenzije/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recenzija = await _context.Recenzija.FindAsync(id);
            if (recenzija == null)
            {
                return NotFound();
            }
            ViewData["KorisnikId"] = new SelectList(_context.Korisnik, "id", "ImePrezime", recenzija.KorisnikId);
            ViewData["RadId"] = new SelectList(_context.Rad, "id", "Naziv", recenzija.RadId);
            return View(recenzija);
        }

        // POST: Recenzije/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ocjena,Komentar,KorisnikId,RadId")] Recenzija recenzija)
        {
            if (id != recenzija.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recenzija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecenzijaExists(recenzija.id))
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
            ViewData["KorisnikId"] = new SelectList(_context.Korisnik, "id", "ImePrezime", recenzija.KorisnikId);
            ViewData["RadId"] = new SelectList(_context.Rad, "id", "Naziv", recenzija.RadId);
            return View(recenzija);
        }

        // GET: Recenzije/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recenzija = await _context.Recenzija
                .Include(r => r.Korisnik)
                .Include(r => r.OcijenjeniRad)
                .FirstOrDefaultAsync(m => m.id == id);
            if (recenzija == null)
            {
                return NotFound();
            }

            return View(recenzija);
        }

        // POST: Recenzije/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recenzija = await _context.Recenzija.FindAsync(id);
            _context.Recenzija.Remove(recenzija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecenzijaExists(int id)
        {
            return _context.Recenzija.Any(e => e.id == id);
        }
    }
}
