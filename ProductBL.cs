using ProductCatalog.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductCatalog.BusinessLogic
{
    public class ProductBL
    {
        private List<Product> products;

        public ProductBL()
        {
            products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    ProductName = "iPhone 17",
                    ProductPrice = 1999,
                    ImageUrl = "/images/iphone.jpg",
                    Description = "Latest Apple iPhone with advanced features"
                },
                new Product
                {
                    Id = 2,
                    ProductName = "AirPods Pro",
                    ProductPrice = 249,
                    ImageUrl = "/images/airpods.jpg",
                    Description = "Noise cancelling wireless earbuds"
                },
                new Product
                {
                    Id = 3,
                    ProductName = "iPad Air",
                    ProductPrice = 599,
                    ImageUrl = "/images/ipad.jpg",
                    Description = "Lightweight tablet for work and entertainment"
                },
                new Product
                {
                    Id = 4,
                    ProductName = "MacBook Pro",
                    ProductPrice = 1800,
                    ImageUrl = "/images/macbook.jpg",
                    Description = "Powerful laptop for professionals"
                },
                new Product
                {
                    Id = 5,
                    ProductName = "Apple Watch",
                    ProductPrice = 399,
                    ImageUrl = "/images/watch.jpg",
                    Description = "Smartwatch with fitness tracking"
                }
            };
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}
