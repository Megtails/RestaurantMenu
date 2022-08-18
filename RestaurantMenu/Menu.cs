using System;

namespace RestaurantMenu
{
    public class Menu
    {
        public Menu()
        {
            public DateTime update = DateTime.Now;
            public List<MenuItem> Items { get; set; }
        }
    }
}



