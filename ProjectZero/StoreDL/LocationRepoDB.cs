using System.Collections.Generic;
using Model = StoreModels;
using Entity = StoreDL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace StoreDL
{
    public class LocationRepoDB : ILocationRepository    
    {
        private Entity.StoreDBContext _context;
        private IMapper _mapper;

        public LocationRepoDB(Entity.StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        /*public Model.Location GetLocationByID(int LocationID)
        {
            return _context.Customers.Select(x => _mapper.ParseCustomer(x)).ToList().FirstOrDefault(x => x.Name == LocationID);
        }*/
        public List<Model.Location> GetLocations()
        {
            return _context.Locations.Select(x => _mapper.ParseLocation(x)).ToList();
        }
    }
}