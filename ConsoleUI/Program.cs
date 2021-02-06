using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAllByCategoryId(5))
            {
                Console.WriteLine("Ürünün Adı: " + product.ProductName + "\n" + "Ürünün Fiyatı: " + product.UnitPrice + "\n");
            }
            Console.ReadLine();
        }
    }
}
