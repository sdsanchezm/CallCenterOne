using CallCenterOne.Models;

namespace CallCenterOne.Interfaces
{
    public interface ICityService
    {
        City GetCityById(int id);
        ICollection<City> GetAllCities();
        bool CreateCity();
        bool UpdateCity(int id);
        bool DeleteCity(int id);
    }
}
