using ASP.NET_Project.Models.Base;

namespace ASP.NET_Project.Models
{
    public class Horse : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Sex { get; set; } = string.Empty;

        public string Breed { get; set; } = string.Empty;

        public string BirthDate { get; set; } = string.Empty;

        public RidingCenter RidingCenter { get; set; } = new RidingCenter();

        public Guid RidingCenterId { get; set; }
    }
}
