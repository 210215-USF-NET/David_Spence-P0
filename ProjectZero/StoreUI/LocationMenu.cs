using System;
using StoreModels;
using StoreBL;
using StoreDL;
using System.Collections.Generic;

namespace StoreUI
{
    public class LocationMenu : IMenu
    {
        IMenu menu;
        private IStoreBL storeBL;
        private Customer customer;
        public List<Location> Locations;
        public LocationMenu(IStoreBL _storeBL, Customer _c)
        {
            storeBL = _storeBL;
            customer = _c;
            Locations = _storeBL.GetLocations();
        }        
public void Start()
        {
            Boolean stay = true;
            do
            {   
                foreach(Location store in Locations)
                {
                    Console.WriteLine(store.Name);
                }
                Console.WriteLine("Enter the name of a location or 9 to exit:");
                string userInput = Console.ReadLine();

                foreach(Location store in Locations)
                {
                    if (userInput.Equals(store.Name))
                    {
                        menu = new OrderingMenu(store, storeBL, customer);
                        menu.Start();
                        break;
                    }else if (userInput.Equals("9"))
                    {
                        stay = false;
                    }
                }
            } while (stay);
        }        
    }
}