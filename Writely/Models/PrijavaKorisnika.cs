using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
   
    [Table ("PrijavaKorisnika")]
    public class PrijavaKorisnika : Prijava
    {
        #region Properties

        [Required]
        [ForeignKey ("KorisnikId")]
        public Korisnik PrijavljeniKorisnik{ get; set; }

        [DisplayName("Status")]
        public int KorisnikId { get; set; }

        #endregion

        #region Konstruktor

        public PrijavaKorisnika(): base( ) {
          
        }
        public PrijavaKorisnika (string naziv, string sadrzaj, Korisnik posiljalac, DateTime datumPrijave, Korisnik prijavljeni) : base(naziv, sadrzaj, posiljalac, datumPrijave)
        {
            PrijavljeniKorisnik = prijavljeni;

        }

        #endregion
    

    }
}
