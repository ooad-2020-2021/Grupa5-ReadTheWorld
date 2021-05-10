using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public class PrijavaRada : Prijava
    {
        #region Properties
        [Required]
        public Rad PrijavljeniRad { get; set; }

        #endregion

        #region Konstruktor
        public PrijavaRada(string naziv, string sadrzaj, Korisnik posiljalac, DateTime datumPrijave, Rad prijavljeni) : base(naziv, sadrzaj, posiljalac, datumPrijave)
        {
            PrijavljeniRad = prijavljeni;

        }

        #endregion

    }
}
