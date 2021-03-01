using System;
using System.Collections.Generic;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    public class LocationBL : ILocationBL
    {
        private ILocationRepository _repo;
        public LocationBL(ILocationRepository repo)
        {
            _repo = repo;
        }
        public List<Location> GetLocations()
        {
            return _repo.GetLocations();
        }
    }
}