using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Semester_Projekt.Models
{
    // Hovedansvarlig: Oliver

    public enum Emner
    {
        Afspillere = 100,
        Dans = 101, 
        Fans = 102, 
        Instrumenter = 103,
        Kultur = 104,
        Lyd = 105,
        Lys = 106,
        [Display(Name = "Musik Genre")]
        MusikGenre = 107,
        Politik = 108
    }
}
