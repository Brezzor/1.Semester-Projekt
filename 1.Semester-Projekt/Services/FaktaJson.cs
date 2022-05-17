using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Semester_Projekt.Models;
using _1.Semester_Projekt.Interfaces;
using _1.Semester_Projekt.Helpers;

namespace _1.Semester_Projekt.Services
{
    public class FaktaJson : IFaktaRepository
    {        
        public Dictionary<int, Fakta> GetAllFakta(string JsonFileName)
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }

        public void CreateFakta(Fakta fakta, string JsonFileName)
        {
            Dictionary<int, Fakta> faktas = GetAllFakta(JsonFileName);
            faktas.Add(fakta.Id, fakta);

            JsonFileWritter.WriteToJson(faktas, JsonFileName);
        }

        public Fakta ReadFakta(int Id, string JsonFileName)
        {
            Dictionary<int, Fakta> faktas = GetAllFakta(JsonFileName);
            return faktas[Id];
        }

        public void UpdateFakta(Fakta fakta, string JsonFileName)
        {
            Dictionary<int, Fakta> faktas = GetAllFakta(JsonFileName);
            foreach (var f in faktas.Values)
            {
                if (f.Id == fakta.Id)
                {
                    faktas[fakta.Id] = fakta;
                }
                JsonFileWritter.WriteToJson(faktas, JsonFileName);
            }
        }
        public void DeleteFakta(Fakta fakta, string JsonFileName)
        {
            Dictionary<int, Fakta> faktas = GetAllFakta(JsonFileName);
            foreach (var f in faktas.Values)
            {
                if (f.Id == fakta.Id)
                {
                    faktas.Remove(f.Id);
                }
            }
            JsonFileWritter.WriteToJson(faktas, JsonFileName);
        }


    }
}
