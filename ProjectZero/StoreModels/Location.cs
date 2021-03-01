using System;

namespace StoreModels
{
    public class Location
    {

        public string Name { get; set; }

        public string City { get; set; }

        public override string ToString() => $"Location Details: \n\t Name: {this.Name} \n\t City: {this.City}";
    }
}