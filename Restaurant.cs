using System;
namespace RestaurantMenu
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            MenuItem garlicBread = new MenuItem("Garlic Bread", 2.99, "Bread topped with butter and garlic.", "Appetizer", false);
            MenuItem toastedRavs = new MenuItem("Toasted Ravioli", 4.99, "Ravioli that has been breaded and fried.", "Appetizer", true);
            MenuItem pizza = new MenuItem("Pizza", 7.99, "A hand-tossed personal pizza with toppings of your choosing.", "Main Course", false);
            MenuItem spaghetti = new MenuItem("Spaghetti", 6.99, "Spaghetti noodles in marinara sauce.", "Main Course", true);
            MenuItem bisotti = new MenuItem("Biscotti", 3.99, "Twice-baked almond biscuits.", "Dessert", false);
            MenuItem tiramisu = new MenuItem("Tiramisu", 5.99, "Lady fingers dipped in coffee and layered with marscapone.", "Dessert", true);

            List<MenuItem> menuItems = new List<MenuItem>();

            menuItems.Add(garlicBread);
            menuItems.Add(toastedRavs);
            menuItems.Add(pizza);
            menuItems.Add(spaghetti);
            menuItems.Add(bisotti);

            Menu newMenu = new Menu(DateTime.Now, menuItems);

            newMenu.AddToMenu(tiramisu);
            newMenu.RemoveFromMenu(garlicBread);

            newMenu.PrintMenu();
        }
    }

}