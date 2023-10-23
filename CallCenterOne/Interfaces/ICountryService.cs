using CallCenterOne.Models;

namespace CallCenterOne.Interfaces
{
    public interface ICountryService
    {
        Country GetCountryById(int id);
        ICollection<Country>  GetAllCountry();
        bool CreateCountry();
        bool UpdateCountry(Customer customer);
        bool DeleteCountry(Customer customer);
    }
}
