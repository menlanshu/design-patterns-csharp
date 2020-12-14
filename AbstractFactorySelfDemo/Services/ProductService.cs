using AbstractFactorySelfDemo.Models;
using AbstractFactorySelfDemo.Services.ProductReaders;
using AbstractFactorySelfDemo.Services.ProductWriters;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySelfDemo.Services
{
    public class ProductService
    {
        private readonly IProductCommunicatorAbstractFactory _productCommunicatorAbstractFactory;

        public ProductService(IProductCommunicatorAbstractFactory productCommunicatorAbstractFactory)
        {
            _productCommunicatorAbstractFactory = productCommunicatorAbstractFactory;
        }

        public Product GetById(Guid id)
        {
            using IProductReader productReader = _productCommunicatorAbstractFactory.CreateProductReader();
            return productReader.GetById(id);
        }

        public Product SaveProduct(Product product)
        {
            using IProductWriter productWriter = _productCommunicatorAbstractFactory.CreateProductWriter();
            return productWriter.SaveProduct(product);
        }
    }
}
