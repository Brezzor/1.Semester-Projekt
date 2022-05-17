using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Semester_Projekt.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _1.Semester_Projekt.Models;

namespace _1.Semester_Projekt.Pages
{
    public class EditModel : PageModel
    {
        private const string AfspillereJsonPath = "./Data/AfspillereFakta.json";
        private const string DansJsonPath = "./Data/DansFakta.json";
        private const string FansJsonPath = "./Data/FansFakta.json";
        private const string InstrumenterJsonPath = "./Data/InstrumenterFakta.json";
        private const string KulturJsonPath = "./Data/KulturFakta.json";
        private const string LydJsonPath = "./Data/LydFakta.json";
        private const string LysJsonPath = "./Data/LysFakta.json";
        private const string MusikGenreJsonPath = "./Data/MusikGenreFakta.json";
        private const string PolitikJsonPath = "./Data/PolitikFakta.json";

        private IFaktaRepository repo;

        public EditModel(IFaktaRepository repository)
        {
            repo = repository;
        }

        public Dictionary<int, Fakta> AfspillereFaktas { get; private set; }
        public Dictionary<int, Fakta> DansFaktas { get; private set; }

        public Dictionary<int, Fakta> FansFaktas { get; private set; }

        public Dictionary<int, Fakta> InstrumenterFaktas { get; private set; }

        public Dictionary<int, Fakta> KulturFaktas { get; private set; }
        public Dictionary<int, Fakta> LydFaktas { get; private set; }
        public Dictionary<int, Fakta> LysFaktas { get; private set; }
        public Dictionary<int, Fakta> MusikGenreFaktas { get; private set; }
        public Dictionary<int, Fakta> PolitikFaktas { get; private set; }

        public IActionResult OnGet()
        {
            AfspillereFaktas = repo.GetAllFakta(AfspillereJsonPath);
            DansFaktas = repo.GetAllFakta(DansJsonPath);
            FansFaktas = repo.GetAllFakta(FansJsonPath);
            InstrumenterFaktas = repo.GetAllFakta(InstrumenterJsonPath);
            KulturFaktas = repo.GetAllFakta(KulturJsonPath);
            LydFaktas = repo.GetAllFakta(LydJsonPath);
            LysFaktas = repo.GetAllFakta(LysJsonPath);
            MusikGenreFaktas = repo.GetAllFakta(MusikGenreJsonPath);
            PolitikFaktas = repo.GetAllFakta(PolitikJsonPath);
            return Page();
        }
    }
}
