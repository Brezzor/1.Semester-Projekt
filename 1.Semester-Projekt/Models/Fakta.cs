using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace _1.Semester_Projekt.Models
{
    public class Fakta
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Emner Emne { get; set; }
        [Required]
        [Display(Name = "Emne Tekst")]
        public string EmneTekst { get; set; }
    }
}
