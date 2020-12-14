using AbstractFactorySelfDemo2.Models;
using System;

namespace AbstractFactorySelfDemo2.Services.ProductService
{
    public interface IProductService
    {
        Product AddProduct(Product product);
        Product GetById(Guid id);
    }
}