using System;
using System.Collections.Generic;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    public class CustomerBL : ICustomerBL
    {
        private ICustomerRepository _repo;
        public CustomerBL(ICustomerRepository repo) 
        {
            _repo = repo;
        }
        public void AddCustomer(Customer newCustomer)
        {
            _repo.AddCustomer(newCustomer);
        }
        public List<Customer> GetCustomer()
        {
            return _repo.GetCustomer();
        }
        public Customer GetCustomerByName(string name)
        {
            //Todo: check if the name given is not null or empty string 
            return _repo.GetCustomerByName(name);
        }
    }
}