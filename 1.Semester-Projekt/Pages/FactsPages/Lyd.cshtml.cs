using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Semester_Projekt.Interfaces;
using _1.Semester_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _1.Semester_Projekt.Pages
{
    public class LydModel : PageModel
    {
        private const string FilePath = "./Data/LydFakta.json";

        public IFaktaRepository repo;

        public LydModel(IFaktaRepository faktaRepository)
        {
            repo = faktaRepository;
        }

        public Dictionary<int, Fakta> Faktas { get; private set; }

        public IActionResult OnGet()
        {
            Faktas = repo.GetAllFakta(FilePath);
            return Page();
        }
    }
}
