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
    public class DeleteAfspillereModel : PageModel
    {
        private const string AfspillserPath = "./Data/AfspillereFakta.json";

        [BindProperty]
        public Fakta Fact { get; set; }

        private IFaktaRepository repo;

        public DeleteAfspillereModel(IFaktaRepository repository)
        {
            repo = repository;
        }
        public void OnGet(int id)
        {
            Fact = repo.ReadFakta(id, AfspillserPath);
        }

        public IActionResult OnPost()
        {
            repo.DeleteFakta(Fact, AfspillserPath);
            return RedirectToPage("/CRUD/Edit");
        }
    }
}
