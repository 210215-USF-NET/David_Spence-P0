using StoreModels;
using System.Collections.Generic;

namespace StoreDL
{
    public interface ICustomerRepository
    {
        Customer AddCustomer(Customer newCustomer);
        List<Customer> GetCustomer();
        Customer GetCustomerByName(string name);
    }
}
