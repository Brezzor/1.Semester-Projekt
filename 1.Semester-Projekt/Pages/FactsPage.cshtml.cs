using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Semester_Projekt.Interfaces;
using _1.Semester_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _1.Semester_Projekt
{
    public class FactsPageModel : PageModel
    {
        private IFaktaRepository catalog;
        public FactsPageModel(IFaktaRepository repository)
        {
            catalog = repository;
        }
        public Dictionary<int, Fakta> Faktas { get; private set; }

        public IActionResult OnGet()
        {
            Faktas = catalog.GetAllFakta();
            return Page();
        }
    }
}
