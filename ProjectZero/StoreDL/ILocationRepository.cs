using StoreModels;
using System.Collections.Generic;

namespace StoreDL
{
    public interface ILocationRepository
    {
        List<Location> GetLocations();
        //3Location GetLocationByID(int LocationID);
    }
}