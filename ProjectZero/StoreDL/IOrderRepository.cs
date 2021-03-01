using StoreModels;
using System.Collections.Generic;

namespace StoreDL
{
    public interface IOrderRepository
    {
       // Order AddOrder(Order newOrder);
        List<Order> GetOrders();
        Order GetOrdersByCustomer(string customerName);
        Order GetOrdersByLocation(string locationName);

    }
}/*
display details of an order
place orders to store locations for customers
view order history of customer
view order history of location
view location inventory
the customer should be able to purchase multiple products
order histories should have the option to be sorted by date 
(latest to oldest vice versa) or cost (least expensive
 to most expensive) */