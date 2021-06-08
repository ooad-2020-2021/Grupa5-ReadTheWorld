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
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 0, ErrorMessage = "Naziv ne smije biti duži od 30 karaktera!")]
        [DisplayName("Naziv rada:")]
        public string Naziv { get; set; }

        [Required]
        [DisplayName("Autor:")]
        [ForeignKey("AutorId")]
        public Korisnik Autor { get; set; }

        [Required]
        [DisplayName("Korisnik")]
        public int AutorId  { get; set; }

        [Required]
        [DisplayName("Žanr:")]
        [EnumDataType (typeof(Žanr))]
        [ForeignKey("ŽanrId")]
        public Žanr žanr { get; set; }

        [Required]
        [DisplayName("Žanr")]
        public int ŽanrId  { get; set; }

        [Required]
        [DisplayName("Kategorija:")]
        [EnumDataType (typeof(Kategorija))]
        [ForeignKey("Kategorija")]
        public Kategorija kategorija { get; set; }
        
        [Required]
        [DisplayName("Kategorija")]
        public int KategorijaId  { get; set; }

        [Required]
        public string Sadržaj { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum objave:")]
        public DateTime DatumObjave { get; set; }

      
        [DisplayName("Tagovi:")]
        public string tagovi { get; set; }

        [DisplayName("Prijavljeno takmičenje")]
        [ForeignKey("TakmičenjeId")]
        public Takmičenje PrijavljenoTakmičenje { get; set; }

        [Required]
        [DisplayName("Takmičenje")]
        public int TakmičenjeId  { get; set; }

        
        #endregion

        #region Konstruktor
        public Rad(string naziv, Korisnik autor, Žanr žanr, Kategorija kategorija, string sadržaj, DateTime datumObjave, string tagovi)
        {
            this.Naziv = naziv;
            this.Autor = autor;
            this.žanr = žanr;
            this.kategorija = kategorija;
            this.Sadržaj = sadržaj;
            this.DatumObjave = datumObjave;
            this.tagovi = tagovi;
        }

        public Rad(string naziv, Korisnik autor, Žanr žanr, Kategorija kategorija, string sadržaj, DateTime datumObjave)
        {
            this.Naziv = naziv;
            this.Autor = autor;
            this.žanr = žanr;
            this.kategorija = kategorija;
            this.Sadržaj = sadržaj;
            this.DatumObjave = datumObjave;
            this.tagovi = "";

        }

        #endregion
    }
}
