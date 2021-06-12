using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Writely.Models
{
    public class TakmičenjeRad
    {
        [Required]
        [Key]
        [ForeignKey("Rad")]
        public int RadId { get; set; }
        
        [Required]
        [ForeignKey("Takmičenje")]
        public int TakmičenjeId { get; set; }
        
        

        
        
        
    }
}