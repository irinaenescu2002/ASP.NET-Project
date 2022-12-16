using ASP.NET_Project.Models;
using ASP.NET_Project.Models.DTOModels;
using ASP.NET_Project.Repositories.Locations;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ASP.NET_Project.Services.Locations
{
    public class LocationService : ILocationService
    {
        public ILocationRepo _ILocationRepo;

        public LocationService (ILocationRepo iLocationRepo)
        {
            _ILocationRepo = iLocationRepo;
        }
        
        public async Task Create(Location location)
        {
            await _ILocationRepo.CreateAsync(location);
            await _ILocationRepo.SaveAsync();
        }

        public async Task Delete(Guid id)
        {
            var location = await _ILocationRepo.FindByIDAsync(id);
            
            await _ILocationRepo.DeleteAsync(location);
            await _ILocationRepo.SaveAsync();
        }

        public IAsyncEnumerable<Location> Get()
        {
             return _ILocationRepo.GetAsync();
        }

        public async Task<bool> Update(DTOLocation location, Guid id)
        {
            var myLocation = await _ILocationRepo.FindByIDAsync(id);

            if (myLocation == null) return false;

            myLocation.Region = location.Region;
            myLocation.City = location.City;
            myLocation.Country = location.Country;  
            myLocation.Street = location.Street;
            myLocation.PostalCode = location.PostalCode;
            myLocation.Number = location.Number;

            await _ILocationRepo.SaveAsync();

            return true;
        }
    }
}
