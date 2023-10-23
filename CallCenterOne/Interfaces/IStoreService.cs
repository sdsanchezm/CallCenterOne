using CallCenterOne.Models;

namespace CallCenterOne.Interfaces
{
    public interface IStoreService
    {
        Store GetStoreById(int id);
        ICollection<Store> GetAllStores();
        bool CreateStors();
        bool UpdateStore(int id);
        bool DeleteStore(int id);
    }
}
