using ASP.NET_Project.Models;
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
    }
}
