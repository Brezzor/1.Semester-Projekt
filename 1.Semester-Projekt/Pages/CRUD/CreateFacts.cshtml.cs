using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Semester_Projekt.Interfaces;
using _1.Semester_Projekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _1.Semester_Projekt.Helpers;

namespace _1.Semester_Projekt.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Fakta Fakta { get; set; }

        private IFaktaRepository catalog;
        public CreateModel(IFaktaRepository repository)
        {
            catalog = repository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/Index");
        }
    }
}
