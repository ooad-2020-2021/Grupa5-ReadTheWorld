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
            rad.recenzije = await _context.Recenzija.Where(m => m.OcijenjeniRad.id == id).ToListAsync();
            //List<string> tagovi = rad.tagovi.Split(",").ToList();
            //rad.tagoviLista = new List<string>();
            //List<int> tagoviID = tagovi.Select(int.Parse).ToList();
            //tagoviID.ForEach(async tagID =>
            //rad.tagoviLista.Add(await _context.Tag.Where(t => t.id == tagID);
            rad.tagoviLista = new List<string> { "knjizevnost", "umjetnost", "ovo", "ono", "ha", "hu" };
            if (rad == null)
            {
                return NotFound();
            }

            return View(rad);
        }



        // GET: Rad
        public IActionResult CreateRadZaTakmicenje(int id)
        {
            ViewData["AutorId"] = new SelectList(_context.Korisnik, "id", "ImePrezime");
            ViewData["TakmičenjeId"] = id;

            return View(id);
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

        // GET: Recenzije/Create
        public IActionResult RecenzijaCreate()
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
        public async Task<IActionResult> RecenzijaCreate([Bind("id,ocjena,Komentar")] Recenzija recenzija)
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
