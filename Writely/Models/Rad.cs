using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public class Rad
    {
        #region Properties
        [Required]
        public string Naziv { get; set; }

        [Required]
        public Korisnik Autor { get; set; }

        [Required]
        public Žanr žanr { get; set; }

        [Required]
        public Kategorija kategorija { get; set; }

        [Required]
        public string Sadržaj { get; set; }

        [Required]
        public DateTime DatumObjave { get; set; }

        [NotMapped]
        public List<string> tagovi { get; set; }

        [NotMapped]
        public List<Recenzija> recenzije { get; set; }
        #endregion

        #region Konstruktor
        public Rad(string naziv, Korisnik autor, Žanr žanr, Kategorija kategorija, string sadržaj, DateTime datumObjave, List<string> tagovi)
        {
            this.Naziv = naziv;
            this.Autor = autor;
            this.žanr = žanr;
            this.kategorija = kategorija;
            this.Sadržaj = sadržaj;
            this.DatumObjave = datumObjave;
            this.tagovi = tagovi;
            this.recenzije = new List<Recenzija>();
        }

        public Rad(string naziv, Korisnik autor, Žanr žanr, Kategorija kategorija, string sadržaj, DateTime datumObjave)
        {
            this.Naziv = naziv;
            this.Autor = autor;
            this.žanr = žanr;
            this.kategorija = kategorija;
            this.Sadržaj = sadržaj;
            this.DatumObjave = datumObjave;
            this.tagovi = new List<string>();
            this.recenzije = new List<Recenzija>();

        }

        #endregion
    }
}
