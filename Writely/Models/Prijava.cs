using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public class Prijava
    {
        #region Properties 

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 0, ErrorMessage = "Naziv prijave ne smije biti duži od 20 karaktera!")]
        [DisplayName("Naziv prijave:")]
        public string Naziv { get; set; }

        [Required]
        [DisplayName("Sadržaj prijave:")]
        public string Sadržaj { get; set; }
        
        [Required]
        public Korisnik Pošiljalac { get; set; }

        [Required]
        [EnumDataType(typeof(StatusPrijave))]
        [DisplayName("Status:")]
        public StatusPrijave Status { get; set; }

        [Required]
        [DataType]
        [DisplayName("Datum prijave:")]
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
