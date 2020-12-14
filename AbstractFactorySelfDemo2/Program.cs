using AbstractFactorySelfDemo2.Models;
using AbstractFactorySelfDemo2.Services.AbstractFactory;
using AbstractFactorySelfDemo2.Services.ProductService;
using System;

namespace AbstractFactorySelfDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Models:
            // Product, with Id, Name, Price

            // Service
            // ProductService

            // Utility
            // FileProductWriter
            // FileProductReader

            // AbstractFactory


            IProductCommunicatorAbstractFactory productCommunicatorAbstractFactory = new InMemoryProductCommunicatorAbstractFactory();
            IProductService productService = new ProductService(productCommunicatorAbstractFactory);


            // add product to json file
            Product product = new Product
            {
                Name = "Long",
                Price = 123M
            };

            try
            {
                productService.AddProduct(product);
                Console.WriteLine($"Product added {product}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception happen {ex.Message}");
            }

            // get product info from json file
            try
            {
                product = productService.GetById(product.Id);
                Console.WriteLine($"Product queried {product}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception happen {ex.Message}");
            }
        }
    }
}
