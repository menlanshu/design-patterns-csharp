using AbstractFactorySelfDemo2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace AbstractFactorySelfDemo2.Services.ProductReader
{
    public class FileProductReader : IProductReader
    {
        public string FileName { get; }
        public bool Disposed { get; set; }

        private ICollection<Product> _products;

        public FileProductReader(string fileName)
        {
            FileName = fileName;

            try
            {
                string productJson = File.ReadAllText(FileName);

                _products = JsonSerializer.Deserialize<ICollection<Product>>(productJson);
            }
            catch (Exception)
            {
                throw new Exception("Exception happen when read file!");
            }
        }


        public Product GetById(Guid id)
        {
            if (Disposed)
            {
                throw new ObjectDisposedException("FileProductReader");
            }

            Product product = _products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                throw new Exception("Product not found");
            }

            return product;
        }

        public void Dispose()
        {
            Disposed = true;
            _products.Clear();
        }
    }
}
