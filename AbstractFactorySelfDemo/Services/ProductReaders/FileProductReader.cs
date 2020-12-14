using AbstractFactorySelfDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace AbstractFactorySelfDemo.Services.ProductReaders
{
    public class FileProductReader : IProductReader
    {
        private ICollection<Product> _products;
        private bool _disposed;

        public string FileName { get; }

        public FileProductReader(string fileName)
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

        public Product GetById(Guid id)
        {
            if (_disposed)
            {
                throw new Exception("Object is disposed.");
            }

            Product product = _products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                throw new Exception("Product not found.");
            }

            return product;
        }

        public void Dispose()
        {
            _disposed = true;
            _products.Clear();
        }
    }
}
