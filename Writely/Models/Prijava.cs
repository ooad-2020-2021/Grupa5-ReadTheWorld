using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public class Prijava
    {
        #region Properties 

        [Required]
        public string Naziv { get; set; }

        [Required]
        public string Sadržaj { get; set; }
        
        [Required]
        public Korisnik Pošiljalac { get; set; }

        [Required]
        public StatusPrijave Status { get; set; }

        [Required]
        public DateTime DatumPrijave { get; set; }

        #endregion

        #region Konstruktor 
        public Prijava (string naziv, string sadrzaj, Korisnik posiljalac, DateTime datumPrijave)
        {
            this.Naziv = naziv;
            this.Sadržaj = sadrzaj;
            this.Pošiljalac = posiljalac;
            this.DatumPrijave = datumPrijave;
            this.Status = StatusPrijave.NaČekanju;
        }

        #endregion
    }
}
