using System;

using MenuCreator.Library;

namespace MenuCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var userMenu = new MenuItem("User Admin");
            userMenu.Add("Create User");
            userMenu.Add("Edit User");

            var productMenu = new MenuItem("Product Admin");
            productMenu.Add("All Products");
            productMenu.AddTo("All Products", "My Products");
            productMenu.Add("Create Product");

            var orderMenu = new MenuItem("Order Admin");
            orderMenu.Add("Order Reports");
            orderMenu.Add("Create Order");
            orderMenu.AddTo("Order Reports", "Audit Reports");
            orderMenu.AddTo("Audit Reports", "Updated Orders");
            orderMenu.AddTo("Audit Reports", "Created Orders");

            var reportsMenu = new MenuItem("Reports");
            reportsMenu.Add("Win Tech Reports");
            reportsMenu.Add("Microsoft Report");

            var mainMenu = new MenuItem();
            mainMenu.Add("Administration");
            mainMenu.AddTo("Administration", userMenu);
            mainMenu.AddTo("Administration", productMenu);
            mainMenu.AddTo("Administration", orderMenu);
            mainMenu.Add(reportsMenu);

            Console.WriteLine(mainMenu.Generate(Environment.NewLine));
            Console.ReadLine();
        }
    }
}