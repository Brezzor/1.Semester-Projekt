using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using _1.Semester_Projekt.Models;
using Newtonsoft.Json;

namespace _1.Semester_Projekt.Helpers
{
        public class JsonFileReader
        {
            public static Dictionary<int, Fakta> ReadJson(string JsonFileName)
            {
                string jsonString = File.ReadAllText(JsonFileName);
                return JsonConvert.DeserializeObject<Dictionary<int, Fakta>>(jsonString);
            }
        }
}
