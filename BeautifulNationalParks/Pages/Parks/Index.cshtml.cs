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
    public class IndexModel : PageModel
    {
        private readonly BeautifulNationalParksContext _context;

        public IndexModel(BeautifulNationalParksContext context)
        {
            _context = context;
        }

        public IList<Park> Park { get;set; }

        public async Task OnGetAsync()
        {
            Park = await _context.Park.ToListAsync();
        }
    }
}
