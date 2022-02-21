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
    public class DetailsModel : PageModel
    {
        private readonly BeautifulNationalParksContext _context;

        public DetailsModel(BeautifulNationalParksContext context)
        {
            _context = context;
        }

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
    }
}
