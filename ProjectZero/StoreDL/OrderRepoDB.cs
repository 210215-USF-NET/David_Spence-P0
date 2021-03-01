using System.Collections.Generic;
using Model = StoreModels;
using Entity = StoreDL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using StoreModels;

namespace StoreDL
{
    public class OrderRepoDB : IOrderRepository
    {
        private Entity.StoreDBContext _context;
        private IMapper _mapper;
        public OrderRepoDB(Entity.StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        /*public Model.Order AddOrder(Model.Order newOrder)
        {
            _context.Orders.Add(_mapper.ParseOrder(newOrder));
            _context.SaveChanges();
            return newOrder;
        }*/

        public List<Order> GetOrders()
        {
            throw new System.NotImplementedException();
        }

        public Order GetOrdersByCustomer(string customerName)
        {
            throw new System.NotImplementedException();
        }

        public Order GetOrdersByLocation(string locationName)
        {
            throw new System.NotImplementedException();
        }
    }
}