using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _1.Semester_Projekt.Interfaces;
using _1.Semester_Projekt.Models;

namespace _1.Semester_Projekt.Pages.CRUD
{
    public class EditPolitikModel : PageModel
    {
        private const string PolitikPath = "./Data/PolitikFakta.json";

        [BindProperty]
        public Fakta Fact { get; set; }

        private IFaktaRepository repo;

        public EditPolitikModel(IFaktaRepository repository)
        {
            repo = repository;
        }

        public void OnGet(int id)
        {
            Fact = repo.ReadFakta(id, PolitikPath);
        }

        public IActionResult OnPost()
        {
            repo.UpdateFakta(Fact, PolitikPath);
            return RedirectToPage("/CRUD/Edit");
        }
    }
}
