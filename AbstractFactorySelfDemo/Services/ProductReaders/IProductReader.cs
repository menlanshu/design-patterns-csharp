using AbstractFactorySelfDemo.Models;
using System;

namespace AbstractFactorySelfDemo.Services.ProductReaders
{
    public interface IProductReader : IDisposable
    {
        string FileName { get; }
        Product GetById(Guid id);
    }
}