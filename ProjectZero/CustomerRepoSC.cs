using System;
using StoreModels;
using System.Collections.Generic;

namespace StoreDL
{
    public class CustomerRepoSC : ICustomerRepository
    {
        public List<Customer> GetCustomer()
        {
            return Storage.AllCustomers;
        }
        public Customer AddCustomer(Customer newCustomer)
        {
            Storage.AllCustomers.Add(newCustomer);
            return newCustomer;
        }
        public Customer GetCustomerByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}