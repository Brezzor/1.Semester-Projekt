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
        private const string AfspillerePath = "./Data/AfspillereFakta.json";
        private const string DansPath = "./Data/DansFakta.json";
        private const string FansPath = "./Data/FansFakta.json";
        private const string InstrumenterPath = "./Data/InstrumenterFakta.json";
        private const string KulturPath = "./Data/KulturFakta.json";
        private const string LydPath = "./Data/LydFakta.json";
        private const string LysPath = "./Data/LysFakta.json";
        private const string MusikGenrePath = "./Data/MusikGenreFakta.json";
        private const string PolitikPath = "./Data/PolitikFakta.json";

        public string EmnePath(int num)
        {
            switch (num)
            {
                case ((int)Emner.Afspillere):
                    return AfspillerePath;
                case ((int)Emner.Dans):
                    return DansPath;
                case ((int)Emner.Fans):
                    return FansPath;
                case ((int)Emner.Instrumenter):
                    return InstrumenterPath;
                case ((int)Emner.Kultur):
                    return KulturPath;
                case ((int)Emner.Lyd):
                    return LydPath;
                case ((int)Emner.Lys):
                    return LysPath;
                case ((int)Emner.MusikGenre):
                    return MusikGenrePath;
                case ((int)Emner.Politik):
                    return PolitikPath;
                default:
                    return "";
            }
        }

        public Dictionary<int, Fakta> GetAllFakta(string JsonFileName)
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }

        public void CreateFakta(Fakta fakta, string JsonFileName)
        {
            Dictionary<int, Fakta> faktas = GetAllFakta(JsonFileName);
            if (fakta != null || !faktas.ContainsKey(fakta.Id))
            {
                faktas.Add(fakta.Id, fakta);
                JsonFileWritter.WriteToJson(faktas, JsonFileName);

            }
        }

        public Fakta ReadFakta(int Id, string JsonFileName)
        {
            Dictionary<int, Fakta> faktas = GetAllFakta(JsonFileName);

            if (!faktas.ContainsKey(Id))
            {
                return null;
            }
            else
            {
                return faktas[Id];

            }
        }

        public void UpdateFakta(Fakta fakta, string JsonFileName)
        {
            Dictionary<int, Fakta> faktas = GetAllFakta(JsonFileName);

            if (fakta != null || !faktas.ContainsKey(fakta.Id))
            {
                faktas[fakta.Id] = fakta;
                JsonFileWritter.WriteToJson(faktas, JsonFileName);
            }

        }

        public void DeleteFakta(Fakta fakta, string JsonFileName)
        {

            if (fakta != null)
            {
                Dictionary<int, Fakta> faktas = GetAllFakta(JsonFileName);
                faktas.Remove(fakta.Id);
                JsonFileWritter.WriteToJson(faktas, JsonFileName);
            }

        }
    }
}
