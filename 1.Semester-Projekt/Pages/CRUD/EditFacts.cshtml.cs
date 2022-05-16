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
    public class EditFactsModel : PageModel
    {
        public Fakta Fact { get; set; }
        private IFaktaRepository catalog;
        public EditFactsModel (IFaktaRepository repository)
        {
            catalog = repository;
        }

        public void OnGet() //(int id) 
        {
            //Fact = catalog.ReadFakta(id);
        }

        public IActionResult OnPost()
        {
            catalog.UpdateFakta(Fact);
            return RedirectToPage("Edit");
        }
    }
}
