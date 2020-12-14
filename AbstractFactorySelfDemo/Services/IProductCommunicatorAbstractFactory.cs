using AbstractFactorySelfDemo.Services.ProductReaders;
using AbstractFactorySelfDemo.Services.ProductWriters;

namespace AbstractFactorySelfDemo.Services
{
    public interface IProductCommunicatorAbstractFactory
    {
        IProductReader CreateProductReader();
        IProductWriter CreateProductWriter();
    }
}