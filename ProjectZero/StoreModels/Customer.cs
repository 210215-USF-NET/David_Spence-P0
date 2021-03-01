﻿using System;

namespace StoreModels
{
    public class Customer
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        //public Address address { get; set; }

        public override string ToString() => $"Customer Details: \n\t Name: {this.Name} \n\t Phone: {this.Phone}";

    }
}