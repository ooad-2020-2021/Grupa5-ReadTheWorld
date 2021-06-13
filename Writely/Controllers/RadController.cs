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
    public class RadController : Controller
    {
        private readonly WritelyDbContext _context;

        public RadController(WritelyDbContext context)
        {
            _context = context;
        }

        // GET: Rad
        public async Task<IActionResult> Index()
        {
            var writelyDbContext = _context.Rad.Include(r => r.Autor);
            return View(await writelyDbContext.ToListAsync());
        }

        // GET: Rad/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rad = await _context.Rad
                .Include(r => r.Autor)
                .FirstOrDefaultAsync(m => m.id == id);
            //rad.recenzije = await _context.Recenzija.Where(m => m.OcijenjeniRad.id == id).ToListAsync();
            rad.recenzije = new List<Recenzija> {
                new Recenzija(9,"Super djelo, zaista sam uživao čitajući"),
                new Recenzija(9,"Super djelo, zaista sam uživao čitajući"),
                new Recenzija(9,"Super djelo, zaista sam uživao čitajući"),
                new Recenzija(9,"Super djelo, zaista sam uživao čitajući"),
                new Recenzija(9,"Super djelo, zaista sam uživao čitajući"),
                new Recenzija(9,"Super djelo, zaista sam uživao čitajući"),
                 };
            //List<string> tagovi = rad.tagovi.Split(",").ToList();
            //rad.tagoviLista = new List<string>();
            //List<int> tagoviID = tagovi.Select(int.Parse).ToList();
            //tagoviID.ForEach(async tagID =>
            //rad.tagoviLista.Add(await _context.Tag.Where(t => t.id == tagID);
            rad.tagoviLista = new List<string>{ "knjizevnost","umjetnost","ovo","ono","ha","hu"};
            if (rad == null)
            {
                return NotFound();
            }

            return View(rad);
        }

        // GET: Rad/Create
        public IActionResult Create()
        {
            ViewData["AutorId"] = new SelectList(_context.Korisnik, "id", "ImePrezime");
            ViewData["TakmičenjeId"] = new SelectList(_context.Takmičenje, "id", "DozvoljeneKategorije");
            return View();
        }
        

        // POST: Rad/Create
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutorId"] = new SelectList(_context.Korisnik, "id", "ImePrezime", rad.AutorId);
            ViewData["TakmičenjeId"] = new SelectList(_context.Takmičenje, "id", "DozvoljeneKategorije", rad.TakmičenjeId);
            return View(rad);
        }

        // GET: Rad/Edit/5
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
            ViewData["TakmičenjeId"] = new SelectList(_context.Takmičenje, "id", "DozvoljeneKategorije", rad.TakmičenjeId);
            return View(rad);
        }

        // POST: Rad/Edit/5
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutorId"] = new SelectList(_context.Korisnik, "id", "ImePrezime", rad.AutorId);
            ViewData["TakmičenjeId"] = new SelectList(_context.Takmičenje, "id", "DozvoljeneKategorije", rad.TakmičenjeId);
            return View(rad);
        }

        // GET: Rad/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rad = await _context.Rad
                .Include(r => r.Autor)
                .Include(r => r.PrijavljenoTakmičenje)
                .FirstOrDefaultAsync(m => m.id == id);
            if (rad == null)
            {
                return NotFound();
            }

            return View(rad);
        }

        // POST: Rad/Delete/5
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
