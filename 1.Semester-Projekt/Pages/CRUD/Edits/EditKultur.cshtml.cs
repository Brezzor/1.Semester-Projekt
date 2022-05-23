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
    public class EditKulturModel : PageModel
    {
        private const string KulturPath = "./Data/KulturFakta.json";

        [BindProperty]
        public Fakta Fact { get; set; }

        private IFaktaRepository repo;

        public EditKulturModel(IFaktaRepository repository)
        {
            repo = repository;
        }

        public void OnGet(int id)
        {
            Fact = repo.ReadFakta(id, KulturPath);
        }

        public IActionResult OnPost()
        {
            repo.UpdateFakta(Fact, KulturPath );
            return RedirectToPage("/CRUD/Edit");
        }
    }
}
