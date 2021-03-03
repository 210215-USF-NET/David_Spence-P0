using System;

namespace StoreModels
{
    public class Item
    {
        //This goes with Inventory
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public override string ToString() => $"Quantity: {this.Quantity}";

    }
}