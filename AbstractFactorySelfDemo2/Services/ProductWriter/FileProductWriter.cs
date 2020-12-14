using AbstractFactorySelfDemo2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace AbstractFactorySelfDemo2.Services.ProductWriter
{
    public class FileProductWriter : IProductWriter
    {
        private ICollection<Product> _products;
        public FileProductWriter(string fileName)
        {
            FileName = fileName;

            try
            {
                string productJson = File.ReadAllText(FileName);

                _products = productJson == "" ? new List<Product>() :
                    JsonSerializer.Deserialize<ICollection<Product>>(productJson);
            }
            catch (Exception ex)
            {
                throw new Exception("Exception happen when read file!");
            }
        }

        public string FileName { get; }

        public bool Disposed { get; set; }

        public Product AddProduct(Product product)
        {
            if (Disposed)
            {
                throw new ObjectDisposedException("FileProductWriter");
            }

            product.Id = Guid.NewGuid();

            _products.Add(product);

            string productJson = JsonSerializer.Serialize(_products);

            File.WriteAllText(FileName, productJson);

            return product;
        }

        public void Dispose()
        {
            Disposed = true;
            _products.Clear();
        }
    }
}
