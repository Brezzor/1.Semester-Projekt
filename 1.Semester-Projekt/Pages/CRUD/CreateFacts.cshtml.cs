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
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Dictionary<int, Fakta> Faktas { get; set; }

        private IFaktaRepository catalog;
        public CreateModel(IFaktaRepository repository)
        {
            catalog = repository;
        }

        public IActionResult OnGet()
        {
            Faktas = catalog.GetAllFakta();
            return Page();
        }
    }
}
