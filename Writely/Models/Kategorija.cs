using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public class Kategorija
    {

        private Kategorija(KategorijaEnum @enum)
        {
            id = (int)@enum;
            ime = @enum.ToString();
            opis = @enum.GetEnumDescription();
        }

        protected Kategorija() { } //For EF

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required, MaxLength(100)]
        public string ime { get; set; }

        [MaxLength(100)]
        public string opis { get; set; }

        public static implicit operator Kategorija(KategorijaEnum @enum) => new Kategorija(@enum);

        public static implicit operator KategorijaEnum(Kategorija kategorija) => (KategorijaEnum)kategorija.id;

    }
}
