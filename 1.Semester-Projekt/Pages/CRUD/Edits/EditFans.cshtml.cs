using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Semester_Projekt.Models;
using _1.Semester_Projekt.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _1.Semester_Projekt.Pages.CRUD
{
    public class EditFansModel : PageModel
    {
        private const string FansPath = "./Data/FansFakta.json";

        [BindProperty]
        public Fakta Fact { get; set; }

        private IFaktaRepository repo;

        public EditFansModel(IFaktaRepository repository)
        {
            repo = repository;
        }

        public void OnGet(int id)
        {
            Fact = repo.ReadFakta(id, FansPath);
        }

        public IActionResult OnPost()
        {
            repo.UpdateFakta(Fact, FansPath);
            return RedirectToPage("Edit");
        }
    }
}
