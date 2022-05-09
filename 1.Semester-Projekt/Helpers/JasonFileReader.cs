using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
