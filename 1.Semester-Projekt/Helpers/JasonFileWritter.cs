using _1.Semester_Projekt.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace _1.Semester_Projekt.Helpers
{
    public class JsonFileWritter
    {
        public static void WriteToJson(Dictionary<int, Fakta> faktas, string JsonFileName)
        {
            string output = JsonConvert.SerializeObject(faktas, Formatting.Indented);

            File.WriteAllText(JsonFileName, output);
        }
    }

}
