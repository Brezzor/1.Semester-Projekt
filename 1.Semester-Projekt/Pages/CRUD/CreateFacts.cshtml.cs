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
        private const string AfspillerePath = "./Data/AfspillereFakta.json";

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

            catalog.CreateFakta(Fakta, EmnePath(((int)Fakta.Emne)));
            return RedirectToPage("/Index");
        }

        private string EmnePath(int num)
        {
            switch (num)
            {
                case 100:
                    return AfspillerePath;
                default:
                    return "";
            }
        }
    }
}
