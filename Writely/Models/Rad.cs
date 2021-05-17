using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [StringLength(maximumLength: 20, MinimumLength = 0, ErrorMessage = "Naziv ne smije biti duži od 20 karaktera!")]
        [DisplayName("Naziv rada:")]
        public string Naziv { get; set; }

        [Required]
        [DisplayName("Autor:")]
        public Korisnik Autor { get; set; }

        [Required]
        [DisplayName("Žanr:")]
        [EnumDataType (typeof(Žanr))]
        public Žanr žanr { get; set; }

        [Required]
        [DisplayName("Kategorija:")]
        [EnumDataType (typeof(Kategorija))]
        public Kategorija kategorija { get; set; }

        [Required]
        public string Sadržaj { get; set; }

        [Required]
        [DataType]
        [DisplayName("Datum objave:")]
        public DateTime DatumObjave { get; set; }

        [NotMapped]
        [DisplayName("Tagovi:")]
        public List<string> tagovi { get; set; }

        
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
