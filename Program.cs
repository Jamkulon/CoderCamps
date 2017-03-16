using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product( int givenId, string supplyName, decimal price)
        {
            Id = givenId;
            Name = supplyName;
            Price = price;
        }
    }
    public class ProductCatalog
    {
        public List<Product> Products { get; set; }

        public Product LookUp(int id)
        {
            Product prodToReturn = null;
            foreach(Product prod in Products)
            {
                if(prod.Id == id)
                {
                    prodToReturn = prod;
                }
                
            }
            return prodToReturn;
        }

        public ProductCatalog()
        {
            Products = new List<Product>()
            {
                new Product(1, "Milk", 1.79m),
                new Product(2, "Eggs", 2.99m),
                new Product(3, "Cheese", 5.99m)
            };
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductCatalog catalog = new ProductCatalog();
            {
                Product prod= catalog.LookUp(2);

                Console.WriteLine("The product with the id of {0} is {1} and costs {2}", prod.Id, prod.Name, prod.Price.ToString("c"));
                Console.ReadLine();
            }
        }
    }
}
