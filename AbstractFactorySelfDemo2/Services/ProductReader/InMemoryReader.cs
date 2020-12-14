using AbstractFactorySelfDemo2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySelfDemo2.Services.ProductReader
{
    public class InMemoryReader : IProductReader
    {
        public string FileName { get; }


        public void Dispose()
        {

        }

        public Product GetById(Guid id)
        {
            return new Product
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Price = 10M
            };
        }
    }
}
