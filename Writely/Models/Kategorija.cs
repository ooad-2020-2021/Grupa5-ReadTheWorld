using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public enum Kategorija
    {
        [Display(Name = "Poezija")] Poezija, [Display(Name = "Esej")] Esej, [Display(Name = "Kratka priča")] KratkaPriča, [Display(Name = "Strip")]  Strip
    }
}
