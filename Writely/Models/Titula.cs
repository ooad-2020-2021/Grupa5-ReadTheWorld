using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public enum Titula
    {
        [Display(Name = "Newbie")] Newbie, [Display(Name = "intermediate")]  Intermediate, [Display(Name = "Pro")]  Pro, [Display(Name = "Award Winner")] AwardWinner
    }
}
