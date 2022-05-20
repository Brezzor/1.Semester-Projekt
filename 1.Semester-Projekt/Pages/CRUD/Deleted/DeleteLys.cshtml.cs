using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _1.Semester_Projekt.Interfaces;
using _1.Semester_Projekt.Models;

namespace _1.Semester_Projekt.Pages.CRUD.Deleted
{
    public class DeleteLysModel : PageModel
    {
        private const string LysPath = "./Data/LysFakta.json";

        [BindProperty]
        public Fakta Fact { get; set; }

        private IFaktaRepository repo;

        public DeleteLysModel(IFaktaRepository repository)
        {
            repo = repository;
        }
        public void OnGet(int id)
        {
            Fact = repo.ReadFakta(id, LysPath);
        }

        public IActionResult OnPost()
        {
            repo.DeleteFakta(Fact, LysPath);
            return RedirectToPage("/CRUD/Edit");
        }
    }
}
