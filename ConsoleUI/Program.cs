using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static ShoppingCartModel cart = new ShoppingCartModel();

        static void Main(string[] args)
        {
            PopulateCartWithDemoData();

            Console.WriteLine($"Money {cart.GenerateTotal(mentionDis,funcDelate, alertUser):C2}");

            Console.WriteLine();
            Console.Write("Please press any key to exit the application...");
            Console.ReadKey();
        }

        public static void mentionDis(decimal subtotal)
        {
            Console.WriteLine(subtotal);
        }

        public static void alertUser(String discount)
        {
            Console.WriteLine(discount);
        }


        public static decimal funcDelate(List<ProductModel> items, decimal subTotal)
        {
            if (subTotal > 100)
                return subTotal * 0.80M;
            else if (subTotal > 50)
                return subTotal * 0.85M;
            else if (subTotal > 10)
                return subTotal * 0.95M;
            return subTotal;
        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }
    }
}
