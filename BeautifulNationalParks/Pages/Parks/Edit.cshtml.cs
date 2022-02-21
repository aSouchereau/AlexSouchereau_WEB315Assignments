using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BeautifulNationalParks.Models;

namespace BeautifulNationalParks.Pages_Parks
{
    public class EditModel : PageModel
    {
        private readonly BeautifulNationalParksContext _context;

        public EditModel(BeautifulNationalParksContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Park).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParkExists(Park.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ParkExists(int id)
        {
            return _context.Park.Any(e => e.ID == id);
        }
    }
}
