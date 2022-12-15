using ASP.NET_Project.Models;

namespace ASP.NET_Project.Services.Locations
{
    public interface ILocationService
    {
        Task Create(Location newLocation);
    }
}
