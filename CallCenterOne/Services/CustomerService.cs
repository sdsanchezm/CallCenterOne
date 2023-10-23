
using CallCenterOne.Interfaces;

namespace CallCenterOne.Services
{
    public class CustomerService
    {
        private readonly ICustomerService _customerService;
        public CustomerService(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public GetCustomer(int id)
        {
            
        }
    }
}
