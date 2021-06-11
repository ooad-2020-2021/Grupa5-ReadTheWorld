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
    public class PrijavaRadaController : Controller
    {
        private readonly WritelyDbContext _context;

        public PrijavaRadaController(WritelyDbContext context)
        {
            _context = context;
        }

        // GET: PrijavaRada
        public async Task<IActionResult> Index()
        {
            var writelyDbContext = _context.PrijavaRada.Include(p => p.Pošiljalac);
            return View(await writelyDbContext.ToListAsync());
        }

        // GET: PrijavaRada/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavaRada = await _context.PrijavaRada
                .Include(p => p.Pošiljalac)
                .FirstOrDefaultAsync(m => m.id == id);
            if (prijavaRada == null)
            {
                return NotFound();
            }

            return View(prijavaRada);
        }

        // GET: PrijavaRada/Create
        public IActionResult Create()
        {
            ViewData["PošiljalacId"] = new SelectList(_context.Korisnik, "id", "ImePrezime");
            return View();
        }

        // POST: PrijavaRada/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RadId,id,Naziv,Sadržaj,PošiljalacId,StatusId,DatumPrijave")] PrijavaRada prijavaRada)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prijavaRada);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PošiljalacId"] = new SelectList(_context.Korisnik, "id", "ImePrezime", prijavaRada.PošiljalacId);
            return View(prijavaRada);
        }

        // GET: PrijavaRada/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavaRada = await _context.PrijavaRada.FindAsync(id);
            if (prijavaRada == null)
            {
                return NotFound();
            }
            ViewData["PošiljalacId"] = new SelectList(_context.Korisnik, "id", "ImePrezime", prijavaRada.PošiljalacId);
            return View(prijavaRada);
        }

        // POST: PrijavaRada/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RadId,id,Naziv,Sadržaj,PošiljalacId,StatusId,DatumPrijave")] PrijavaRada prijavaRada)
        {
            if (id != prijavaRada.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prijavaRada);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrijavaRadaExists(prijavaRada.id))
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
            ViewData["PošiljalacId"] = new SelectList(_context.Korisnik, "id", "ImePrezime", prijavaRada.PošiljalacId);
            return View(prijavaRada);
        }

        // GET: PrijavaRada/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavaRada = await _context.PrijavaRada
                .Include(p => p.Pošiljalac)
                .FirstOrDefaultAsync(m => m.id == id);
            if (prijavaRada == null)
            {
                return NotFound();
            }

            return View(prijavaRada);
        }

        // POST: PrijavaRada/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prijavaRada = await _context.PrijavaRada.FindAsync(id);
            _context.PrijavaRada.Remove(prijavaRada);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrijavaRadaExists(int id)
        {
            return _context.PrijavaRada.Any(e => e.id == id);
        }
    }
}
