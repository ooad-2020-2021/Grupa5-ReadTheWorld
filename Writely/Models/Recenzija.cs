using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public class Recenzija
    {
        #region Properties

        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        [DisplayName("Ocjena:")]
        [Range(1, 5, ErrorMessage = "Ocjena mora biti između 1 i 5!")]
        public int ocjena { get; set; }

        [StringLength(maximumLength: 500, MinimumLength = 0, ErrorMessage = "Komentar ne smije biti duži od 500 karaktera!")]
        [DisplayName("Komentar:")]
        public string Komentar { get; set; }

        [Required]
        [DisplayName("Korisnik:")]
        [ForeignKey ("KorisnikId")]
        public Korisnik Korisnik { get; set; }
        
        [DisplayName("Korisnik")]
        public int KorisnikId { get; set; }

        [Required]
        [ForeignKey("RadId")]
        [DisplayName("Rad:")]
        public Rad OcijenjeniRad { get; set; }

        [DisplayName("Rad")]
        public int RadId { get; set; }



        #endregion

        #region Konstruktor

        Recenzija (int ocjena, string komentar, Korisnik korisnik)
        {
            this.ocjena = ocjena;
            this.Komentar = komentar;
            this.Korisnik = korisnik;
        }

        Recenzija(int ocjena, Korisnik korisnik)
        {
            this.ocjena = ocjena;
            this.Komentar = "";
            this.Korisnik = korisnik;
        }

        #endregion
    }
}
