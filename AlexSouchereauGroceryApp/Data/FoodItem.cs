using System;

namespace AlexSouchereauGroceryApp.Data
{
    public class FoodItem
    {
        public int Quantity { get; set; }
        public int FoodName { get; set; }

        public string FoodGroup { get; set; }
        public int Calories { get; set; }
        public decimal Price { get; set; }

    }
}