using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public class PrijavaKorisnika : Prijava
    {
        #region Properties
        [Required]
        public Korisnik PrijavljeniKorisnik{ get; set; }

        #endregion

        #region Konstruktor
        public PrijavaKorisnika (string naziv, string sadrzaj, Korisnik posiljalac, DateTime datumPrijave, Korisnik prijavljeni) : base(naziv, sadrzaj, posiljalac, datumPrijave)
        {
            PrijavljeniKorisnik = prijavljeni;

        }

        #endregion
    }
}
