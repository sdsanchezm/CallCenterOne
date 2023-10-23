using CallCenterOne.Models;

namespace CallCenterOne.Interfaces
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int id);
        ICollection<Customer> GetAllCustomers();
        bool CreateCustomer();
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
    }

}
