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
        private const string AfspillerePath = "./Data/AfspillereFakta.json";

        [BindProperty]
        public Fakta Fact { get; set; }

        private IFaktaRepository repo;
        
        public EditFactModel (IFaktaRepository repository)
        {
            repo = repository;
        }

        public void OnGet(int id) 
        {
            Fact = repo.ReadFakta(id, AfspillerePath);
        }

        public IActionResult OnPost()
        {
            repo.UpdateFakta(Fact, AfspillerePath);
            return RedirectToPage("Edit");
        }
    }
}
