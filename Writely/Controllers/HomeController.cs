using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Writely.Data;
using Writely.Models;

namespace Writely.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WritelyDbContext _context;

        
        public HomeController(ILogger<HomeController> logger, WritelyDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        public static IEnumerable<Rad> GetRadovi()  
        {  
            List<Rad> lstCutomers = new List<Rad>()  
            {  
                new Rad("Prvi rad", null, null, null, "tekst prvog rada", DateTime.Now),
                new Rad("Drugi rad", null, null, null, "tekst drugog rada", DateTime.Now),
                new Rad("treci rad", null, null, null, "tekst treceg rada", DateTime.Now),
                new Rad("4 rad", null, null, null, "tekst 4. rada", DateTime.Now),
                 
            };  
            return lstCutomers;  
        }  

        public async Task<IActionResult> Index()
        {
            return View(await _context.Rad.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
