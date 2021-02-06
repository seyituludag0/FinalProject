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
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());
            //foreach (var product in productManager.GetAllByCategoryId(5))
            //{
            //    Console.WriteLine("Ürünün Adı: " + product.ProductName + "\n" + "Ürünün Fiyatı: " + product.UnitPrice + "\n");
            //}

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine("Category Id: " + category.CategoryId + " Category Name: " + category.CategoryName);
            }

            Console.ReadLine();
        }
    }
}
