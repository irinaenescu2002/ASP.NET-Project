using ASP.NET_Project.Models.Base;

namespace ASP.NET_Project.Models
{
    public class RidingCenter : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Location Location { get; set; } = new Location();

        public List<Horse> Horses { get; set; } = new List<Horse> { new Horse() };

        public Guid LocationID { get; set; }
    }
}
