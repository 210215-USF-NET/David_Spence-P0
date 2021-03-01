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
                Phone = customer.CustomerPhone
            };
        }
        public Entity.Customer ParseCustomer(Model.Customer customer)
        {
            return new Entity.Customer
            {
                CustomerName = customer.Name,
                CustomerPhone = customer.Phone
            };
        }
        public Model.Location ParseLocation(Entity.Location location)
        {
            return new Model.Location
            {
                Name = location.LocationName,
                City = location.City
            };
        }
        public Model.Product ParseProduct(Entity.Product product)
        {
            return new Model.Product
            {
                Name = product.ProductName,
                Price = (double) product.Price
            };
        }
        /* public Model.Order ParseOrder(Entity.Order)
{
    return new Model.Order
    {

    };
} */

    }
}