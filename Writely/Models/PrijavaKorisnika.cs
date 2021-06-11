﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
   
    [Table ("PrijavaKorisnika")]
    public class PrijavaKorisnika 
    {
        #region Properties 
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 0, ErrorMessage = "Naziv prijave ne smije biti duži od 20 karaktera!")]
        [DisplayName("Naziv prijave:")]
        public string Naziv { get; set; }

        [Required]
        [DisplayName("Sadržaj prijave:")]
        public string Sadržaj { get; set; }
        
        [Required]
        [ForeignKey ("PošiljalacId")]
        public Korisnik Pošiljalac { get; set; }

        [DisplayName("Korisnik")]
        public int PošiljalacId { get; set; }

        [NotMapped]
        [EnumDataType(typeof(StatusPrijave))]
        [DisplayName("Status:")]
        
        public StatusPrijave Status { get; set; }

        [ForeignKey("StatusId")]
        [DisplayName("Status")]
        public int StatusId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum prijave:")]
        public DateTime DatumPrijave { get; set; }
        
        [ForeignKey("Prijava")]
        [Required]
        public int PrijavaId { get; set; }
        
        [NotMapped]
        [Required]
        [ForeignKey ("KorisnikId")]
        public Korisnik PrijavljeniKorisnik{ get; set; }

        [DisplayName("KorisnikId")]
        [Required]
        public int KorisnikId { get; set; }

        #endregion

        #region Konstruktor

        public PrijavaKorisnika()
        {
            
        }

        #endregion
        

        

        
    

    }
}
