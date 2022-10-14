using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { ID = 2, CategoryID = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //PascalCase     //camelCase
            ProductManager productManager = new ProductManager();

            productManager.Add(product1);
            


            Console.ReadLine();
        }
    }
}
