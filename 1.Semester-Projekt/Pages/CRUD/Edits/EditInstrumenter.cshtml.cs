using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Semester_Projekt.Models;
using _1.Semester_Projekt.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _1.Semester_Projekt.Pages
{
    public class EditInstrumenterModel : PageModel
    {
        private const string InstrumenterPath = "./Data/InstrumenterFakta.json";

        [BindProperty]
        public Fakta Fact { get; set; }

        private IFaktaRepository repo;

        public EditInstrumenterModel(IFaktaRepository repository)
        {
            repo = repository;
        }

        public void OnGet(int id)
        {
            Fact = repo.ReadFakta(id, InstrumenterPath);
        }

        public IActionResult OnPost()
        {
            repo.UpdateFakta(Fact, InstrumenterPath);
            return RedirectToPage("Edit");
        }
    }
}
