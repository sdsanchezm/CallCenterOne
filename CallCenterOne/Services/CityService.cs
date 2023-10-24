using CallCenterOne.Data;
using CallCenterOne.Interfaces;
using CallCenterOne.Models;

namespace CallCenterOne.Services
{
    public class CityService : ICityService
    {
        DataContext _context;
        public CityService(DataContext context)
        {
            _context = context;
        }

        public bool CreateCity()
        {
            throw new NotImplementedException();
        }

        public bool DeleteCity(int id)
        {
            var c = _context.CityDbSet.FirstOrDefault(x => x.Id == id);
            _context.Remove(c);
            return Save();
        }

        public ICollection<City> GetAllCities()
        {
            return _context.CityDbSet.OrderBy(x => x.Id).ToList();
        }

        public City GetCityById(int id)
        {
            var c = _context.CityDbSet.Where(c => c.Id == id).FirstOrDefault();
            return c;
        }

        public bool UpdateCity(City city)
        {
            var id = city.Id;

            var c = _context.CityDbSet.Where(c => c.Id == id).FirstOrDefault();
            if (c == null)
            {
                return false;
            }

            return true;
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool CityExists(int id)
        {
            var c = _context.CityDbSet.Any(x => x.Id == id);
            return c;
        }
    }
}
