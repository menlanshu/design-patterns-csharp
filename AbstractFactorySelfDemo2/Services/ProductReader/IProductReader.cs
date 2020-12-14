using AbstractFactorySelfDemo2.Models;
using System;

namespace AbstractFactorySelfDemo2.Services.ProductReader
{
    public interface IProductReader : IDisposable
    {
        public string FileName { get; }
        Product GetById(Guid id);
    }
}