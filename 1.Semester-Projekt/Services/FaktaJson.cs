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

        private static string EmnePath(Emner emne)
        {
            switch (emne)
            {
                case (Emner.Afspillere):
                    return AfspillerePath;
                case (Emner.Dans):
                    return DansPath;
                case (Emner.Fans):
                    return FansPath;
                case (Emner.Instrumenter):
                    return InstrumenterPath;
                case (Emner.Kultur):
                    return KulturPath;
                case (Emner.Lyd):
                    return LydPath;
                case (Emner.Lys):
                    return LysPath;
                case (Emner.MusikGenre):
                    return MusikGenrePath;
                case (Emner.Politik):
                    return PolitikPath;
                default:
                    return "";
            }
        }

        public Dictionary<int, Fakta> GetAllFakta(string JsonFileName)
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }

        public void CreateFakta(Fakta fakta)
        {
            Dictionary<int, Fakta> faktas = GetAllFakta(EmnePath(fakta.Emne));

            if (fakta != null || !faktas.ContainsKey(fakta.Id))
            {
                faktas.Add(fakta.Id, fakta);
                JsonFileWritter.WriteToJson(faktas, EmnePath(fakta.Emne));

            }
        }

        public Fakta ReadFakta(int Id, Emner emne)
        {
            Dictionary<int, Fakta> faktas = GetAllFakta(EmnePath(emne));

            if (!faktas.ContainsKey(Id))
            {
                return null;
            }
            else
            {
                return faktas[Id];

            }
        }

        public void UpdateFakta(Fakta fakta)
        {
            Dictionary<int, Fakta> faktas = GetAllFakta(EmnePath(fakta.Emne));

            if (fakta != null || !faktas.ContainsKey(fakta.Id))
            {
                faktas[fakta.Id] = fakta;
                JsonFileWritter.WriteToJson(faktas, EmnePath(fakta.Emne));
            }

        }

        public void DeleteFakta(Fakta fakta)
        {

            if (fakta != null)
            {
                Dictionary<int, Fakta> faktas = GetAllFakta(EmnePath(fakta.Emne));
                faktas.Remove(fakta.Id);
                JsonFileWritter.WriteToJson(faktas, EmnePath(fakta.Emne));
            }

        }
    }
}
