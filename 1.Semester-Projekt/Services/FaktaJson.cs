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
        string JsonFileName = "~/Data/jsonFakta.json";

        public Dictionary<int, Fakta> GetAllFakta()
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }

        public void CreateFakta(Fakta fakta)
        {
            Dictionary<int, Fakta> faktas = GetAllFakta();
            faktas.Add(fakta.Id, fakta);

            JsonFileWritter.WriteToJson(faktas, JsonFileName);
        }

        public Fakta ReadFakta(int id)
        {
            Dictionary<int, Fakta> faktas = GetAllFakta();
            return faktas[id];
        }

        public void UpdateFakta(Fakta fakta)
        {
            Dictionary<int, Fakta> faktas = GetAllFakta();
            foreach (var f in faktas.Values)
            {
                if (f.Id == fakta.Id)
                {
                    f.Emne = fakta.Emne;
                }
                JsonFileWritter.WriteToJson(faktas, JsonFileName);
            }
        }
        public void DeleteFakta(Fakta fakta)
        {
            Dictionary<int, Fakta> faktas = GetAllFakta();
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
