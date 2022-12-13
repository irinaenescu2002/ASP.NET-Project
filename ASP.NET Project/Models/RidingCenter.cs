using ASP.NET_Project.Models.Base;

namespace ASP.NET_Project.Models
{
    public class RidingCenter : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Location Location { get; set; } = new Location();

        public Guid LocationID { get; set; }
    }
}
