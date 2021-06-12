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
    public class TakmičenjeRadController : Controller
    {
        private readonly WritelyDbContext _context;

        public TakmičenjeRadController(WritelyDbContext context)
        {
            _context = context;
        }

        // GET: TakmičenjeRad
        public async Task<IActionResult> Index()
        {
            return View(await _context.TakmičenjeRad.ToListAsync());
        }

        // GET: TakmičenjeRad/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takmičenjeRad = await _context.TakmičenjeRad
                .FirstOrDefaultAsync(m => m.RadId == id);
            if (takmičenjeRad == null)
            {
                return NotFound();
            }

            return View(takmičenjeRad);
        }

        // GET: TakmičenjeRad/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TakmičenjeRad/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RadId,TakmičenjeId")] TakmičenjeRad takmičenjeRad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(takmičenjeRad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(takmičenjeRad);
        }

        // GET: TakmičenjeRad/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takmičenjeRad = await _context.TakmičenjeRad.FindAsync(id);
            if (takmičenjeRad == null)
            {
                return NotFound();
            }
            return View(takmičenjeRad);
        }

        // POST: TakmičenjeRad/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RadId,TakmičenjeId")] TakmičenjeRad takmičenjeRad)
        {
            if (id != takmičenjeRad.RadId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(takmičenjeRad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TakmičenjeRadExists(takmičenjeRad.RadId))
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
            return View(takmičenjeRad);
        }

        // GET: TakmičenjeRad/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takmičenjeRad = await _context.TakmičenjeRad
                .FirstOrDefaultAsync(m => m.RadId == id);
            if (takmičenjeRad == null)
            {
                return NotFound();
            }

            return View(takmičenjeRad);
        }

        // POST: TakmičenjeRad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var takmičenjeRad = await _context.TakmičenjeRad.FindAsync(id);
            _context.TakmičenjeRad.Remove(takmičenjeRad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TakmičenjeRadExists(int id)
        {
            return _context.TakmičenjeRad.Any(e => e.RadId == id);
        }
    }
}
