using System;
namespace RestaurantMenu
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool New { get; set; }

        public MenuItem(string itemName, double price, string description, string category, bool isNew)
        {
            Name = itemName;
            Price = price;
            Description = description;
            Category = category;
            New = isNew;
        }
    }
}

