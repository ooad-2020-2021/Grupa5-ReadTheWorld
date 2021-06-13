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
    public class ObjavljivanjeRadaController : Controller
    {
        private readonly WritelyDbContext _context;

        public ObjavljivanjeRadaController(WritelyDbContext context)
        {
            _context = context;
        }



   

        // POST: ObjavljivanjeRada/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Naziv,AutorId,ŽanrId,KategorijaId,Sadržaj,DatumObjave,tagovi,TakmičenjeId")] Rad rad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(HomeController));
            }
            ViewData["AutorId"] = new SelectList(_context.Korisnik, "id", "ImePrezime", rad.AutorId);
            return View(rad);
        }

        // GET: ObjavljivanjeRada/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rad = await _context.Rad.FindAsync(id);
            if (rad == null)
            {
                return NotFound();
            }
            ViewData["AutorId"] = new SelectList(_context.Korisnik, "id", "ImePrezime", rad.AutorId);
            rad.DatumObjave = DateTime.Now;
            return View(rad);
        }

        // POST: ObjavljivanjeRada/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Naziv,AutorId,ŽanrId,KategorijaId,Sadržaj,DatumObjave,tagovi,TakmičenjeId")] Rad rad)
        {
            if (id != rad.id)
            {
                return NotFound();
            }

            rad.DatumObjave = DateTime.Now;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RadExists(rad.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(HomeController));
            }
            ViewData["AutorId"] = new SelectList(_context.Korisnik, "id", "ImePrezime", rad.AutorId);
            return View(rad);
        }

        // GET: ObjavljivanjeRada/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rad = await _context.Rad
                .Include(r => r.Autor)
                .FirstOrDefaultAsync(m => m.id == id);
            if (rad == null)
            {
                return NotFound();
            }

            return View(rad);
        }

        // POST: ObjavljivanjeRada/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rad = await _context.Rad.FindAsync(id);
            _context.Rad.Remove(rad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RadExists(int id)
        {
            return _context.Rad.Any(e => e.id == id);
        }
    }
}
