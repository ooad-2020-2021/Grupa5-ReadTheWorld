using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public class Recenzija
    {
        #region Properties
        [Required]
        public Ocjena ocjena { get; set; }

        public string Komentar { get; set; }

        [Required]
        public Korisnik Korisnik { get; set; }

        #endregion

        #region Konstruktor

        Recenzija (Ocjena ocjena, string komentar, Korisnik korisnik)
        {
            this.ocjena = ocjena;
            this.Komentar = komentar;
            this.Korisnik = korisnik;
        }

        Recenzija(Ocjena ocjena, Korisnik korisnik)
        {
            this.ocjena = ocjena;
            this.Komentar = "";
            this.Korisnik = korisnik;
        }

        #endregion
    }
}
