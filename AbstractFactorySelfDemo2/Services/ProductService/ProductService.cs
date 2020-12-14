using AbstractFactorySelfDemo2.Models;
using AbstractFactorySelfDemo2.Services.AbstractFactory;
using AbstractFactorySelfDemo2.Services.ProductReader;
using AbstractFactorySelfDemo2.Services.ProductWriter;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySelfDemo2.Services.ProductService
{
    public class ProductService : IProductService
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

        public Product AddProduct(Product product)
        {
            using IProductWriter productWriter = _productCommunicatorAbstractFactory.CreateProductWriter();
            return productWriter.AddProduct(product);
        }
    }
}
