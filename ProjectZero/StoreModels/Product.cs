using System;

namespace StoreModels
{
    public class Product
    {
        //Name, Price
        public string Name { get; set; }

        public double Price { get; set; }

        public override string ToString() => $"Product Details: \n\t Name: $ {this.Name} \n\t Price: {this.Price}";

    }
}