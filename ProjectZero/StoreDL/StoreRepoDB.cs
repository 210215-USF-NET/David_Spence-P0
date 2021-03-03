using System.Collections.Generic;
using Model = StoreModels;
using Entity = StoreDL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using StoreModels;

namespace StoreDL
{
    public class StoreRepoDB : IStoreRepository
    {
         private Entity.StoreDBContext _context;
         private IMapper _mapper;  
         public StoreRepoDB(Entity.StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }             
 //CUSTOMER***********************************************************
        public void AddCustomer(Model.Customer newCustomer)
        {
            _context.Customers.Add(_mapper.ParseCustomer(newCustomer));
            _context.SaveChanges();
            //return newCustomer;
        }
        public List<Model.Customer> GetCustomer()
        {
            return _context.Customers.Select(x => _mapper.ParseCustomer(x)).ToList();
        }
        public Model.Customer GetCustomerByName(string name)
        {
            return _context.Customers.Select(x => _mapper.ParseCustomer(x)).ToList().FirstOrDefault(x => x.Name == name);
        }
//LOCATION***********************************************************
        List<Location> IStoreRepository.GetLocations()
        {
            return _context.Locations.Select(x => _mapper.ParseLocation(x)).ToList();
        }
//ORDER***********************************************************
        /*public Model.Order AddOrder(Model.Order newOrder)
        {
            _context.Orders.Add(_mapper.ParseOrder(newOrder));
            _context.SaveChanges();
            return newOrder;
        }*/        
        public List<Model.Order> GetOrders()
        {
            return _context.Orders.AsNoTracking().Select(x => _mapper.ParseOrder(x)).ToList();
        }
        public Model.Order GetOrdersByCustomerId(int CustomerId)
        {
            return _context.Orders.Select(x => _mapper.ParseOrder(x)).ToList().FirstOrDefault(x => x.CustomerId == CustomerId);
        }
        public List<Model.Order> GetOrdersByLocation(string locationName)
        {
            throw new System.NotImplementedException();
        }                    
        //PRODUCT***********************************************************
        public List<Model.Product> GetProducts()
        {
            return _context.Products.AsNoTracking().Select(x => _mapper.ParseProduct(x)).ToList();
        }
        public Model.Product GetProductById(int Id)
        {
            return _context.Products.Select(x => _mapper.ParseProduct(x)).ToList().FirstOrDefault(x => x.Id == Id);
        }
        List<Customer> IStoreRepository.GetCustomer()
        {
            return _context.Customers.Select(x => _mapper.ParseCustomer(x)).ToList();
        }

        Customer IStoreRepository.GetCustomerByName(string name)
        {
            return _context.Customers.Select(x => _mapper.ParseCustomer(x)).ToList().FirstOrDefault(x => x.Name == name);
        }
        List<Order> IStoreRepository.GetOrders()
        {
            return _context.Orders.AsNoTracking().Select(x => _mapper.ParseOrder(x)).ToList();
        }
        List<Order> IStoreRepository.GetOrdersByLocation(string locationName)
        {
            throw new System.NotImplementedException();
        }

        List<Product> IStoreRepository.GetProducts()
        {
            return _context.Products.Select(x => _mapper.ParseProduct(x)).ToList();
        }

        public List<Order> GetCustomerOrderHistory(string name)
        {
            throw new System.NotImplementedException();
        }

        public List<Inventory> GetInventories()
        {
            return _context.Inventories.AsNoTracking().Select(x => _mapper.ParseInventory(x)).ToList();
        }
        public Model.Item AddItemToOrder(Model.Item newItem)
        {
            _context.OrderItems.Add(_mapper.ParseItem(newItem));
            _context.SaveChanges();
            return newItem;
        }

        Customer IStoreRepository.AddCustomer(Customer newCustomer)
        {
            throw new System.NotImplementedException();
        }

        public void AddOrder(Model.Order newOrder)
        {
            _context.Orders.Add(_mapper.ParseOrder(newOrder));
            _context.SaveChanges();        }

         Location GetLocationNameById(int id)
        {
           return _context.Locations.Select(x => _mapper.ParseLocation(x)).ToList().FirstOrDefault(x => x.Id == id);
        }
        List<Item> GetItems()
        {
            return _context.OrderItems.Select(x => _mapper.ParseItem(x)).ToList();
        }

        List<Item> IStoreRepository.GetItems()
        {
            return _context.OrderItems.Select(x => _mapper.ParseItem(x)).ToList();
        }
    }
}