using FactorySelfDemo.Model;

namespace FactorySelfDemo.Factory
{
    public interface IOnlineStoreFactory
    {
        IOnlineStore CreateStore(string name);
    }
}