using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public class Takmičenje
    {
        public string naziv { get; set; }
        public DateTime DatumPocetka { get; set; }

        public DateTime DatumKraja { get; set; }

        public List<Kategorija> DozvoljeneKategorije { get; set; }

        public string Opis { get; set; }

        public List<Rad> radovi { get; set; }
    }
}
