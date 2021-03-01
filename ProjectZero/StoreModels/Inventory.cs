using System;

namespace StoreModels
{
    public class Inventory
    {
        public Location Location { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}