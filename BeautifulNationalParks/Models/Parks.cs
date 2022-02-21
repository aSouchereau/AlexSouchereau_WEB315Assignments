using System;
using System.ComponentModel.DataAnnotations;

namespace BeautifulNationalParks.Models
{
    public class Park
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DateEstablished { get; set; }
        public string Location { get; set; } = string.Empty;
        public decimal Area { get; set; }
        public string Climate { get; set; }
    }
}