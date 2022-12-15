using ASP.NET_Project.Context;
using ASP.NET_Project.Models;
using ASP.NET_Project.Repositories.Generic;

namespace ASP.NET_Project.Repositories.Locations
{
    public class LocationRepo : Generic<Location>, ILocationRepo
    {
        public LocationRepo(DBContext context) : base(context) { }
    }
}
