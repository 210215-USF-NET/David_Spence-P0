using Model = StoreModels;
using Entity = StoreDL.Entities;
using StoreModels;
using StoreDL.Entities;
using System.Linq;
using System.Collections.Generic;

namespace StoreDL
{
    public class StoreMapper : IMapper
    {
        public Model.Customer ParseCustomer(Entity.Customer customer)
        {
            return new Model.Customer
            {
                Name = customer.CustomerName,
                Phone = customer.CustomerPhone,
                Id = customer.CustomerId
            };
        }
        public Entity.Customer ParseCustomer(Model.Customer customer)
        {
            return new Entity.Customer
            {
                CustomerName = customer.Name,
                CustomerPhone = customer.Phone,
                CustomerId = customer.Id
            };
        }
        public Model.Location ParseLocation(Entity.Location location)
        {
            return new Model.Location
            {
                Name = location.LocationName,
                City = location.City,
                Id = location.Id
            };
        }
        public Model.Product ParseProduct(Entity.Product product)
        {
            return new Model.Product
            {
                Name = product.ProductName,
                Price = (double) product.Price,
                Id = product.Id
            };
        }
        public Entity.Location ParseLocation(Model.Location location)
        {
            return new Entity.Location
            {
                LocationName = location.Name,
                City = location.City
            };
        }
        public Model.Order ParseOrder(Entity.Order order)
        {
            return new Model.Order
            {
                OrderNumber = order.Id,
                //Date = order.OrderDate,
                CustomerId = order.CustomerId,
                LocationId = order.LocationId
            };
        }
        public Entity.Order ParseOrder(Model.Order order)
        {
            return new Entity.Order
            {
                Id = order.OrderNumber, 
                CustomerId = order.CustomerId,
                LocationId = order.LocationId
            };        
        }
        public Model.Inventory ParseInventory(Entity.Inventory inventory)
        {
            return new Model.Inventory 
            {
                Id = inventory.Id,
                Quantity = inventory.Quantity,
                LocationId = inventory.LocationId,
                ProductId = inventory.ProductId
            };
        }

        public Entity.Inventory ParseInventory(Model.Inventory inventory)
        {
            return new Entity.Inventory 
            {
                Id = inventory.Id,
                Quantity = inventory.Quantity,
                LocationId = inventory.LocationId,
                ProductId = inventory.ProductId
            };
        }

        public Model.Item ParseItem(Entity.OrderItem item)
        {
            return new Model.Item
            {
            ProductId = item.ProductId,
            OrderId = item.OrderId,
            Quantity = item.Quantity
            };
        }

        public Entity.OrderItem ParseItem(Model.Item item)
        {
            return new Entity.OrderItem
            {
                ProductId = item.ProductId,
                OrderId = item.OrderId,
                Quantity = item.Quantity
            };
        }
    }
}