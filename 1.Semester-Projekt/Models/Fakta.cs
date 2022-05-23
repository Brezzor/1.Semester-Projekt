using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace _1.Semester_Projekt.Models
{
    public class Fakta
    {
        public int Id { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Emner Emne { get; set; }
        public string EmneTekst { get; set; }
    }
}
