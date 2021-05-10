using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public class Korisnik

    {
        #region Properties

        [Required]
        public string ImePrezime { get; set; }

        [Required]
        public DateTime DatumRegistracije { get; set; }

        [NotMapped]
        public List<Rad> ObjavljeniRadovi { get; set; }

        [NotMapped]
        public List<Titula> DodijeljeneTitule { get; set; }

        public Titula AktuelnaTitula { get; set; }

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
