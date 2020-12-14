using AbstractFactorySelfDemo.Models;
using System;

namespace AbstractFactorySelfDemo.Services.ProductWriters
{
    public interface IProductWriter : IDisposable
    {
        string FileName { get; }

        Product SaveProduct(Product product);
    }
}