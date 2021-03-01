using System;
using StoreModels;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace StoreDL
{
    public class CustomerRepoFile : ICustomerRepository
    {
        private string jsonString;
        private string filePath = "../StoreDL/CustomerFiles.json";
        public Customer AddCustomer(Customer newCustomer)
        {
            List<Customer> customersFromFile = GetCustomer();
            customersFromFile.Add(newCustomer);
            jsonString = JsonSerializer.Serialize(customersFromFile);
            File.WriteAllText(filePath, jsonString);
            return newCustomer;
        }
        public List<Customer> GetCustomer()
        {
            try
            {
                jsonString = File.ReadAllText(filePath);
            }
            catch (Exception)
            {
                return new List<Customer>();
            }
            return JsonSerializer.Deserialize<List<Customer>>(jsonString);
        }
        public Customer GetCustomerByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}