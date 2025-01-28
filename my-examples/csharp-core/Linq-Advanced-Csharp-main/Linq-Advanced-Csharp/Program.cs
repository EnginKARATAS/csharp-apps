using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Advanced_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="sebzeler"},
                new Category{CategoryId=2,CategoryName="meyveler"}
            };

            List<Product> products = new List<Product>{
            new Product{ProductId=1, CategoryId=1,ProductName="maydanoz"},
            new Product{ProductId=2, CategoryId=1,ProductName="marul"},
            new Product{ProductId=3, CategoryId=2,ProductName="domates"}
            };

            //call "maydanoz" and category id = 1 via every method and non-mathod 

            //nolinq
            foreach (var item in products)
            {
                if (item.ProductId == 1 && item.ProductName == "maydanoz")
                {
                    Console.WriteLine(item.ProductName);
                }
            }

            //nolinql via method 
            foreach (var item in GetProducts(products))
            {
                Console.WriteLine(item.ProductName);
            }

            List<Product> GetProducts(List<Product> productsParam)
            {
                List<Product> containerProducts = new List<Product>();
                foreach (var item in productsParam)
                {
                    if (item.ProductId == 1 && item.ProductName == "maydanoz")
                    {
                        containerProducts.Add(item);
                    }
                }
                return containerProducts;
            }

            ////linq       
            var result = products.Where(p => p.ProductId == 1 && p.ProductName == "maydanoz");
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }

            foreach (var item in GetProducts2(products))
            {
                Console.WriteLine(item.ProductName);
            }

            ////linq via method
            List<Product> GetProducts2(List<Product> productsParam)
            {
                return productsParam.Where(p => p.ProductId == 1 && p.ProductName == "maydanoz").ToList();
            }

            Console.Read();

        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
