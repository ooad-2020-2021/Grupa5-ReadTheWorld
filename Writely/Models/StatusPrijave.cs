using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public class StatusPrijave
    {

        private StatusPrijave(StatusPrijaveEnum @enum)
        {
            id = (int)@enum;
            ime = @enum.ToString();
            opis = @enum.GetEnumDescription();
        }

        protected StatusPrijave() { } //For EF

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required, MaxLength(100)]
        public string ime { get; set; }

        [MaxLength(100)]
        public string opis { get; set; }

        public static implicit operator StatusPrijave(StatusPrijaveEnum @enum) => new StatusPrijave(@enum);

        public static implicit operator StatusPrijaveEnum(StatusPrijave statusPrijave) => (StatusPrijaveEnum)statusPrijave.id;

    }
}
