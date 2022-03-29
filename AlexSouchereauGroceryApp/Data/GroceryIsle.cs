using System;
using System.Collections.Generic;

namespace AlexSouchereauGroceryApp.Data
{
    public class GroceryIsle
    {
        public List<FoodItem> StockedFood { get; set; }
        public string IsleName { get; set; }
        public int IsleNumber { get; set; }
    }
}