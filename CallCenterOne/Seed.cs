using CallCenterOne.Data;
using CallCenterOne.Models;

namespace CallCenterOne
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            if (!_context.CustomerDbSet.Any())
            {
                var customer1 = new Customer
                {
                    Firstname = "Jamecho",
                    Lastname = "Sanc",
                    PhoneNumber = "1234567890",
                    Address = "987 Some Where Ave",
                    ZipCode = "4X1 99P"
                };

                var customer2 = new Customer
                {
                    Firstname = "Jara",
                    Lastname = "Sanc",
                    PhoneNumber = "987654321",
                    Address = "123 Some Where St",
                    ZipCode = "4X1 99U"
                };

                var city1 = new City
                {
                    CityName = "Berlin",
                    CreationDate = DateTime.Now,
                    //CustomerId = 1,
                    //Customer = customer1,
                };

                var city2 = new City
                {
                    CityName = "Paris",
                    CreationDate = DateTime.Now,
                    //CustomerId = 2,
                    //Customer = customer2,
                };

                _context.CustomerDbSet.Add(customer1);
                _context.CustomerDbSet.Add(customer2);
                _context.CityDbSet.Add(city1);
                _context.CityDbSet.Add(city2);
                _context.SaveChanges();
            }
        }

    }
}
