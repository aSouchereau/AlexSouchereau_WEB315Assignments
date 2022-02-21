using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeautifulNationalParks.Models;

namespace BeautifulNationalParks.Pages_Parks
{
    public class CreateModel : PageModel
    {
        private readonly BeautifulNationalParksContext _context;

        public CreateModel(BeautifulNationalParksContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Park Park { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Park.Add(Park);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
