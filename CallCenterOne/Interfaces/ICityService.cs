using CallCenterOne.Models;

namespace CallCenterOne.Interfaces
{
    public interface ICityService
    {
        City GetCityById(int id);
        ICollection<City> GetAllCities();
        bool CreateCity();
        bool UpdateCity(City city);
        bool DeleteCity(int id);
        bool Save();
        bool CityExists(int id);
    }
}
