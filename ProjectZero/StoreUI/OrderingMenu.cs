using System;
using StoreModels;
using StoreBL;
using StoreDL;
using System.Collections.Generic;
using System.Linq;

namespace StoreUI
{
    public class OrderingMenu : IMenu
    {
        IStoreBL storeBL;
        Customer customer;
        Location location;
        List<Product> prods = new List<Product>();
         
        

        public OrderingMenu(Location _location, IStoreBL _storeBL, Customer _customer)
        {
            storeBL = _storeBL;
            customer = _customer;
            location = _location;
            //prods(_location);
        }        
        public void Start()
        {
            Boolean stay = true;
            do
            {            
            GetProducts();
            Console.WriteLine("Would you like to place an order?");
            Console.WriteLine("[1] Yes");
            Console.WriteLine("[2] No");
            string userInput = Console.ReadLine();     

            switch (userInput)
            {
                case "1":
                    CreateOrder();
                    break;
                case "2":
                    stay = false;
                    break;
                default:
                    Console.WriteLine("Invalid input! Not part of menu options! >:[");
                    break;
                }
            } while (stay);                          
        }            

        public void CreateOrder()
        {
            Order ord = new Order();
            Item itm = new Item();
            GetProducts();
            Console.WriteLine("Please enter the product id:");
            int userInput = int.Parse(Console.ReadLine());
            itm.ProductId = userInput;
            Console.WriteLine("How many?");
            userInput = int.Parse(Console.ReadLine());
            itm.Quantity = userInput;
            ord.CustomerId = customer.Id;
            ord.LocationId = location.Id;            
            Console.WriteLine(customer.ToString());
            Console.WriteLine(location.ToString());
            storeBL.AddOrder(ord);
            //storeBL.AddItemToOrder(itm);

        }
        public void GetProducts()
        {
            foreach (Product item in storeBL.GetProducts())
            {
                Console.WriteLine(item.ToString());
            }
        }
    } 
}