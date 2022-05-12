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
    public class KulturModel : PageModel
    {
        [BindProperty]
        public Fakta Fakta { get; set; }

        private IFaktaRepository catalog;

        public KulturModel(IFaktaRepository repository)
        {
            catalog = repository;
        }        

        public IActionResult OnGet(int id)
        {
            Fakta = catalog.ReadFakta(id);
            return Page();
        }
    }
}
