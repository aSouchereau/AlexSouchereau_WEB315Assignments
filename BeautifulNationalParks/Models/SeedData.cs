using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BeautifulNationalParks.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BeautifulNationalParksContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BeautifulNationalParksContext>>()))
            {
                if (context == null || context.Park == null)
                {
                    throw new ArgumentNullException("Null BeautifulNationalParks Context");
                }

                // Look for any parks.
                if (context.Park.Any())
                {
                    return;   // DB has been seeded
                }

                context.Park.AddRange(
                    new Park
                    {
                        Name = "Point Pelee",
                        DateEstablished = DateTime.Parse("1918-5-29"),
                        Location = "Leamington, ON",
                        Area = 15,
                        Climate = "Humid Continental"
                    },

                    new Park
                    {
                        Name = "Pukaskwa",
                        DateEstablished = DateTime.Parse("1978-1-1"),
                        Location = "Heron Bay, ON",
                        Area = 1878,
                        Climate = "Humid Continental"
                    },

                    new Park
                    {
                        Name = "Gros Morne",
                        DateEstablished = DateTime.Parse("2005-10-1"),
                        Location = "Rocky Harbour, NL",
                        Area = 1805,
                        Climate = "Warm Summer Continental"
                    },

                    new Park
                    {
                        Name = "Prince Edward Island NP",
                        DateEstablished = DateTime.Parse("1937-1-1"),
                        Location = "Brackley Beach, PEI",
                        Area = 15,
                        Climate = "Warm Summer Continental"
                    },

                    new Park
                    {
                        Name = "Jasper",
                        DateEstablished = DateTime.Parse("1907-9-14"),
                        Location = "Jasper, AB",
                        Area = 10878,
                        Climate = "Subartic"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}