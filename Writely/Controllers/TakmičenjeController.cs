using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Writely.Data;
using Writely.Models;

namespace Writely.Controllers
{
    public class TakmičenjeController : Controller
    {
        private readonly WritelyDbContext _context;

        public TakmičenjeController(WritelyDbContext context)
        {
            _context = context;
        }

        // GET: Takmičenje
        public async Task<IActionResult> Index()
        {
            return View(await _context.Takmičenje.ToListAsync());
        }

        // GET: Takmičenje/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takmičenje = await _context.Takmičenje
                .FirstOrDefaultAsync(m => m.id == id);
            if (takmičenje == null)
            {
                return NotFound();
            }

            return View(takmičenje);
        }

        [Authorize (Roles = "Administrator")]
        // GET: Takmičenje/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Takmičenje/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Naziv,DatumPocetka,DatumKraja,DozvoljeneKategorije,Opis")] Takmičenje takmičenje)
        {
            if (ModelState.IsValid)
            {
                _context.Add(takmičenje);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(takmičenje);
        }

        [Authorize (Roles = "Administrator")]
        // GET: Takmičenje/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takmičenje = await _context.Takmičenje.FindAsync(id);
            if (takmičenje == null)
            {
                return NotFound();
            }
            return View(takmičenje);
        }

        [Authorize (Roles = "Administrator")]
        // POST: Takmičenje/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Naziv,DatumPocetka,DatumKraja,DozvoljeneKategorije,Opis")] Takmičenje takmičenje)
        {
            if (id != takmičenje.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(takmičenje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TakmičenjeExists(takmičenje.id))
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
            return View(takmičenje);
        }

        [Authorize (Roles = "Administrator")]
        // GET: Takmičenje/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takmičenje = await _context.Takmičenje
                .FirstOrDefaultAsync(m => m.id == id);
            if (takmičenje == null)
            {
                return NotFound();
            }

            return View(takmičenje);
        }

        [Authorize (Roles = "Administrator")]
        // POST: Takmičenje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var takmičenje = await _context.Takmičenje.FindAsync(id);
            _context.Takmičenje.Remove(takmičenje);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TakmičenjeExists(int id)
        {
            return _context.Takmičenje.Any(e => e.id == id);
        }
    }
}
