using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeautifulNationalParks.Models;

    public class BeautifulNationalParksContext : DbContext
    {
        public BeautifulNationalParksContext (DbContextOptions<BeautifulNationalParksContext> options)
            : base(options)
        {
        }

        public DbSet<BeautifulNationalParks.Models.Park> Park { get; set; }
    }
