using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    
    public class Korisnik

    {
        #region Properties

        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        [StringLength(maximumLength: 25, MinimumLength = 0, ErrorMessage = "Ime korisnika ne smije biti duže od 25 karaktera!")]
        [RegularExpression(@"[ |a-z|A-Z]*",
         ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova i razmaka!")]
        [DisplayName("Ime i prezime:")]
        public string ImePrezime { get; set; }

        [Required]
        [DataType]
        [DisplayName("Datum registracije:")]
        public DateTime DatumRegistracije { get; set; }

        [DisplayName("Dodijeljene titule:")]
        public string DodijeljeneTitule { get; set; }

        [DisplayName("Aktuelna titula:")]
        [EnumDataType(typeof(Titula))]
        [ForeignKey("Titula")]
        public Titula AktuelnaTitula { get; set; }

        [DisplayName("Writely moto:")]
        public string WritelyMoto { get; set; }

        #endregion

        #region Konstruktor
        public Korisnik (string ime, DateTime datumRegistracije, string moto)
        {
            this.ImePrezime = ime;
            this.DatumRegistracije = datumRegistracije;
            this.WritelyMoto = moto;
            this.ObjavljeniRadovi = new List<Rad>();
            this.DodijeljeneTitule = new List<Titula>();
            this.DodijeljeneTitule.Add(Titula.Newbie);
            this.AktuelnaTitula = Titula.Newbie;
        }

        #endregion

        #region Metode
        void dodajRad (Rad r)
        {
            ObjavljeniRadovi.Add(r);
        }

        void obrisiRad (Rad r)
        {
            ObjavljeniRadovi.Remove(r);
        }


        #endregion

    }
}
