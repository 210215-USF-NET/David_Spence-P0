using System;
using StoreModels;
using StoreBL;
using StoreDL;

namespace StoreUI
{
    public class StoreMenu : IMenu
    {
        public ICustomerBL _customerBL;
        public ILocationBL _locationBL;
        public IProductBL _productBL;

        public StoreMenu(ICustomerBL customerBL, ILocationBL locationBL, IProductBL productBL)
        {
            _customerBL = customerBL;
            _locationBL = locationBL;
            _productBL = productBL;

        }
        public void Start()
        {
            Boolean stay = true;
            do
            {
                //menu options
                Console.WriteLine("Welcome to the plastic fruit store!");
                Console.WriteLine("[0] Create a customer");
                Console.WriteLine("[1] Get all customers");
                Console.WriteLine("[2] Search for a customer");
                Console.WriteLine("[3] Show  all Location details");
                Console.WriteLine("[4] List all products");
                Console.WriteLine("[5] Exit");

                //get user input
                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();

                                switch (userInput)
                {
                    case "0":
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
                    case "1":
                        GetCustomer();
                        break;
                    case "2":
                        SearchCustomer();
                        break;
                    case "3":
                        GetLocations();
                        break;
                    case "4":
                        GetProducts();
                        break;
                    case "5":
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
            
            _customerBL.AddCustomer(newCustomer);

            Console.WriteLine("Customer Succesfully created!");

        }
        public void GetCustomer()
        {
            foreach (var item in _customerBL.GetCustomer())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public void SearchCustomer()
        {
            Console.WriteLine("Enter customer name: ");
            Customer foundCustomer = _customerBL.GetCustomerByName(Console.ReadLine());
            if (foundCustomer == null)
            {
                Console.WriteLine("No such customer found :<");
            }
            else
            {
                Console.WriteLine(foundCustomer.ToString());
            }
        }
        public void GetLocations()
        {
            foreach (var item in _locationBL.GetLocations())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public void GetProducts()
        {
            foreach (var item in _productBL.GetProducts())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public void ExitRemarks()
        {
            Console.WriteLine("Goodbye friend! See you next time!");
        }
    }
}