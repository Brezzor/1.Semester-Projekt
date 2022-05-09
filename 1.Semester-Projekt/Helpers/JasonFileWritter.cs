using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Semester_Projekt.Helpers
{
    public class JsonFileWritter
    {
        public static void WriteToJson(Dictionary<int, Fakta> faktas, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(faktas,
                                                               Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(JsonFileName, output);
        }
    }

}
