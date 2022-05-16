using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Semester_Projekt.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _1.Semester_Projekt.Models;

namespace _1.Semester_Projekt.Pages
{
    public class EditModel : PageModel
    {
        private IFaktaRepository catalog;
        public EditModel(IFaktaRepository repository)
        {
            catalog = repository;
        }
        public Dictionary<int, Fakta> Faktas { get; private set; }

        public IActionResult OnGet()
        {
            Faktas = catalog.GetAllFakta();
            if (true)
            {
                Faktas = catalog.GetAllFakta();
            }
            return Page();
        }
        
        public IActionResult DeleteFact(int id)
        {
            catalog.DeleteFakta(catalog.ReadFakta(id));
            return Page();
        }
    }
}
