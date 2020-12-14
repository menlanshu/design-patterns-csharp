using AbstractFactorySelfDemo.Models;
using AbstractFactorySelfDemo.Services;
using System;

namespace AbstractFactorySelfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductCommunicatorAbstractFactory productCommunicatorAbstractFactory = new FileProductCommunicatorAbstractFactory("product.json");
            ProductService productService = new ProductService(productCommunicatorAbstractFactory);

            // Get product.
            try
            {
                Product product = productService.GetById(new Guid("34cb0113-2b54-4f86-98bc-a1a70d5817fd"));
                Console.WriteLine(product);
            }
            catch (Exception)
            {
                Console.WriteLine("Product not found.");
            }

            // Save new product.
            try
            {
                Product savedProduct = productService.SaveProduct(new Product()
                {
                    Name = "Desk",
                    Price = 49.99M
                });
                Console.WriteLine(savedProduct);
            }
            catch (Exception)
            {
                Console.WriteLine("Product saved failed.");
            }
        }
    }
}
