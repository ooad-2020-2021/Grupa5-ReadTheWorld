using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public class Takmičenje
    {
        #region Properties
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 0, ErrorMessage = "Naziv takmičenja ne smije biti duže od 30 karaktera!")]
        [DisplayName("Naziv takmičenja:")]
        public string  Naziv { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum početka:")]
        public DateTime DatumPocetka { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum kraja:")]
        public DateTime DatumKraja { get; set; }

        [Required]
        [DisplayName("Dozvoljene kategorije:")]
        public string DozvoljeneKategorije { get; set; }

        [Required]
        [DisplayName("Opis teme:")]
        public string Opis { get; set; }


        public List<Rad> radovi { get; set; }
        #endregion

        #region Konstruktor
        public Takmičenje (string naziv, DateTime datumPocetka, DateTime datumKraja, string dozvoljeneKategorije, string opis)
        {
            this.Naziv = naziv;
            this.DatumPocetka = datumPocetka;
            this.DatumKraja = datumKraja;
            this.DozvoljeneKategorije = dozvoljeneKategorije;
            this.Opis = opis;
            this.radovi = new List<Rad>();
        }

        #endregion
    }
}
