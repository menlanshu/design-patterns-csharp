using AbstractFactorySelfDemo2.Models;
using System;

namespace AbstractFactorySelfDemo2.Services.ProductWriter
{
    public interface IProductWriter : IDisposable
    {
        public string FileName { get; }
        Product AddProduct(Product product);
    }
}