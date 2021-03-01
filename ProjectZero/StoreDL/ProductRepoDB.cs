using System.Collections.Generic;
using Model = StoreModels;
using Entity = StoreDL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using StoreModels;

namespace StoreDL
{
    public class ProductRepoDB : IProductRepository
    {
        private Entity.StoreDBContext _context;
        private IMapper _mapper;

        public ProductRepoDB(Entity.StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Product> GetProducts()
        {
            return _context.Products.Select(x => _mapper.ParseProduct(x)).ToList();
        }
    }
}