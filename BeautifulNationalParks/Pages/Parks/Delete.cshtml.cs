using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeautifulNationalParks.Models;

namespace BeautifulNationalParks.Pages_Parks
{
    public class DeleteModel : PageModel
    {
        private readonly BeautifulNationalParksContext _context;

        public DeleteModel(BeautifulNationalParksContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Park Park { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Park = await _context.Park.FirstOrDefaultAsync(m => m.ID == id);

            if (Park == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Park = await _context.Park.FindAsync(id);

            if (Park != null)
            {
                _context.Park.Remove(Park);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
