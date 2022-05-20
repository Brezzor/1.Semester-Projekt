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
    public class EditAfspillereModel : PageModel
    {
        private const string AfspillerePath = "./Data/AfspillereFakta.json";

        [BindProperty]
        public Fakta Afspillere { get; set; }

        private IFaktaRepository repo;
        
        public EditAfspillereModel (IFaktaRepository repository)
        {
            repo = repository;
        }

        public void OnGet(int id) 
        {
            Afspillere = repo.ReadFakta(id, AfspillerePath);
        }

        public IActionResult OnPost()
        {
            repo.UpdateFakta(Afspillere, AfspillerePath);
            return RedirectToPage("/CRUD/Edit");
        }
    }
}
