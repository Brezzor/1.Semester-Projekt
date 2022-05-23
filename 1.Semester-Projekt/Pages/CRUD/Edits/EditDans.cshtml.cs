using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Semester_Projekt.Interfaces;
using _1.Semester_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _1.Semester_Projekt.Pages.CRUD
{
    public class EditDansModel : PageModel
    {
        private const string DansPath = "./Data/DansFakta.json";

        [BindProperty]
        public Fakta Dans { get; set; }

        private IFaktaRepository repo;

        public EditDansModel(IFaktaRepository repository)
        {
            repo = repository;
        }

        public void OnGet(int id)
        {
            Dans = repo.ReadFakta(id, DansPath);
        }

        public IActionResult OnPost()
        {
            repo.UpdateFakta(Dans, DansPath);
            return RedirectToPage("/CRUD/Edit");
        }
    }
}
