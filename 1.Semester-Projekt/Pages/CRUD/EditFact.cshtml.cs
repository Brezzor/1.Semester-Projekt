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

        private Emner Emne { get; set; }

        private IFaktaRepository repo;
        
        public EditFactModel(IFaktaRepository repository)
        {
            repo = repository;
        }

        public void OnGet(int id, Emner emne) 
        {
            Fakta = repo.ReadFakta(id, emne);
            Emne = emne;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.UpdateFakta(Fakta);
            return RedirectToPage("/CRUD/Edit");
        }
    }
}
