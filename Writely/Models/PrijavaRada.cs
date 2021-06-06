using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    [Table("PrijavaRada")]
    public class PrijavaRada : Prijava
    {
        #region Properties
        
        [Required]
        [ForeignKey "RadId"]
        public Rad PrijavljeniRad { get; set; }

        [DisplayName "Rad"]
        public int RadId { get; set; }

        #endregion

        #region Konstruktor
        public PrijavaRada(string naziv, string sadrzaj, Korisnik posiljalac, DateTime datumPrijave, Rad prijavljeni) : base(naziv, sadrzaj, posiljalac, datumPrijave)
        {
            PrijavljeniRad = prijavljeni;

        }

        #endregion

    }
}
