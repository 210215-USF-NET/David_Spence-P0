using System;
using System.Collections.Generic;

namespace StoreModels
{
    public class Order
    {
        public int OrderNumber { get; set; }

        public double Total { get; set; }

        public Location Location { get; set; }

        public List<Product> ListOfItems { get; set; }

        public override string ToString() => $"Order Details: \n\t Total: $ {this.Total} \n\t Location: {this.Location.Name}";

    }
}