using System;
using StoreModels;
using StoreBL;
using StoreDL;
using System.Collections.Generic;

namespace StoreUI
{
    public class StoreEntryMenu : IMenu
    {
        
        IMenu menu; 
        public IStoreBL storeBL;

        public StoreEntryMenu(IStoreBL _storeBL)
        {
            storeBL = _storeBL;
        }
        public void Start()
        {
            Boolean stay = true;
            do
            {
                //menu options
                Console.WriteLine("Welcome to the plastic fruit store!");
                Console.WriteLine("[1] Sign up as a new Customer");
                Console.WriteLine("[2] Login as an existing Customer");
                //Manager login
                Console.WriteLine("[3] List all Customers");
                Console.WriteLine("[9] Exit");
                //get user input
                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        try
                        {
                            CreateCustomer();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("invalid input." + e.Message);
                            continue;
                        }
                        break;
                    case "2":
                        SearchCustomer();
                        break;
                    case "3":
                        GetCustomers();
                        break;
                    case "9":
                        stay = false;
                        ExitRemarks();
                        break;
                    default:
                        Console.WriteLine("Invalid input! Not part of menu options! >:[");
                        break;
                }
            } while (stay);
    }
        public void CreateCustomer()
        {
            // Create hero method/logic
            Customer newCustomer = new Customer();
            Console.WriteLine("Enter Customer Name: ");
            newCustomer.Name = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            newCustomer.Phone = Console.ReadLine();
            storeBL.AddCustomer(newCustomer);
            Console.WriteLine("Customer Succesfully created!");
            CustomerLogin(newCustomer);
        }
        public void GetCustomers()
        {
            foreach (var item in storeBL.GetCustomer())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public void SearchCustomer()
        {
            Console.WriteLine("Enter customer name: ");
            Customer foundCustomer = storeBL.GetCustomerByName(Console.ReadLine());
            if (foundCustomer == null)
            {
                Console.WriteLine("No such customer found :<");
            }
            else
            {
                //Console.WriteLine(foundCustomer.ToString());
                CustomerLogin(foundCustomer);
            }
        }
        public void CustomerLogin(Customer c)
        {
            //start customer menu
            menu = new CustomerMenu(storeBL, c);
            menu.Start();
        }
        public void ExitRemarks()
        {
            Console.WriteLine("Goodbye friend! See you next time!");
        }
    }
}