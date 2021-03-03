using System;
using StoreModels;
using StoreBL;
using StoreDL;
using System.Collections.Generic;

namespace StoreUI
{
    public class CustomerMenu : IMenu
    {
        IMenu menu;
        public IStoreBL storeBL;
        private Customer customer;
        public CustomerMenu(IStoreBL _storeBL, Customer _c){
            customer = _c;
            storeBL = _storeBL;
        }
        public void Start()
        {
            Boolean stay = true;
            do
            {
                Console.WriteLine("[1] Place an order");
                Console.WriteLine("[2] View order history");
                Console.WriteLine("[9] Exit");

                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        menu = new LocationMenu(storeBL, customer);
                        menu.Start();
                        break;
                    case "2":
                        GetCustomerOrderHistory();
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
        public void GetProducts()
        {
            foreach (var item in storeBL.GetProducts())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public void GetCustomerOrderHistory()
        {
            foreach (var Ord in storeBL.GetOrders())
            {
                if (Ord.CustomerId == customer.Id)
                {
                    Console.WriteLine(Ord.ToString());

                    foreach (var Loc in storeBL.GetLocations()){
                        if (Loc.Id == Ord.LocationId)
                        {
                            Console.WriteLine(Loc.ToString());
                        }
                    }
                    foreach (var Itm in storeBL.GetItems()){
                        if (Itm.OrderId == Ord.OrderNumber){
                            foreach (var Prod in storeBL.GetProducts()){
                                if (Itm.ProductId == Prod.Id){
                                    Console.WriteLine(Prod.ToString());
                                    Console.WriteLine(Itm.ToString());
                                    Console.WriteLine();
                                }
                            }
                        }
                    }                    
                }
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