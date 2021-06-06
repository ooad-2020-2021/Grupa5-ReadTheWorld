using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public enum StatusPrijave
    {
        [Display(Name = "Na čekanju")] NaČekanju, [Display(Name = "Obrađena")]  Obrađena, [Display(Name = "Odbijena")] Odbijena
    }
}
