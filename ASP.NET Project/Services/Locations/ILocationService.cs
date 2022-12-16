using ASP.NET_Project.Models;
using ASP.NET_Project.Models.DTOModels;
using System.Collections.Generic;

namespace ASP.NET_Project.Services.Locations
{
    public interface ILocationService
    {
        Task Create(Location newLocation);

        Task Delete(Guid id);

        IAsyncEnumerable<Location> Get();

        Task<bool> Update(DTOLocation location, Guid id);
    }
}
