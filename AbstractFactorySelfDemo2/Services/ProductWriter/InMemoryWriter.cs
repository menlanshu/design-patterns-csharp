using AbstractFactorySelfDemo2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySelfDemo2.Services.ProductWriter
{
    public class InMemoryWriter : IProductWriter
    {
        public string FileName { get;  }


        public Product AddProduct(Product product)
        {
            product.Id = Guid.NewGuid();
            return product;
        }

        public void Dispose()
        {
        }
    }
}
