﻿using Business.Concrate;
using DataAccess.Concrate.EntityFramework;
using DataAccess.Concrate.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal() );
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }

            //ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
