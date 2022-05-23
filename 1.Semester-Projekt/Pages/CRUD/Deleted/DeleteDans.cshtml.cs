using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _1.Semester_Projekt.Interfaces;
using _1.Semester_Projekt.Models;

namespace _1.Semester_Projekt.Pages
{
    public class DeleteDansModel : PageModel
    {
        private const string DansPath = "./Data/DansFakta.json";

        [BindProperty]
        public Fakta Fact { get; set; }

        private IFaktaRepository repo;

        public DeleteDansModel(IFaktaRepository repository)
        {
            repo = repository;
        }
        public void OnGet(int id)
        {
            Fact = repo.ReadFakta(id, DansPath);
        }

        public IActionResult OnPost()
        {
            repo.DeleteFakta(Fact, DansPath);
            return RedirectToPage("/CRUD/Edit");
        }
    }
}
