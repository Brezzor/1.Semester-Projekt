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
    public class EditFactModel : PageModel
    {
        [BindProperty]
        public Fakta Fakta { get; set; }

        private IFaktaRepository repo;
        
        public EditFactModel(IFaktaRepository repository)
        {
            repo = repository;
        }

        public void OnGet(int id, Emner emne) 
        {
            Fakta = repo.ReadFakta(id, repo.EmnePath((int)emne));
        }

        public IActionResult OnPost()
        {
            repo.UpdateFakta(Fakta, repo.EmnePath((int)Fakta.Emne));
            return RedirectToPage("/CRUD/Edit");
        }
    }
}
