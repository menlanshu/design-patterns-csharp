using AbstractFactorySelfDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace AbstractFactorySelfDemo.Services.ProductWriters
{
    public class FileProductWriter : IProductWriter
    {
        private ICollection<Product> _products;
        private bool _disposed;

        public string FileName { get; }

        public FileProductWriter(string fileName)
        {
            try
            {
                string productJson = File.ReadAllText(fileName);
                _products = JsonSerializer.Deserialize<ICollection<Product>>(productJson);
            }
            catch (Exception)
            {
                _products = new List<Product>();
            }
            FileName = fileName;
        }

        public Product SaveProduct(Product product)
        {
            if (_disposed)
            {
                throw new Exception("Object is disposed");
            }

            product.Id = Guid.NewGuid();

            _products.Add(product);
            string productJson = JsonSerializer.Serialize<ICollection<Product>>(_products);

            File.WriteAllText(FileName, productJson);

            return product;
        }


        public void Dispose()
        {
            _disposed = true;
            _products.Clear();
        }
    }
}
