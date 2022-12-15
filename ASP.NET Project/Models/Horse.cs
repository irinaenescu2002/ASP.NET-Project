using ASP.NET_Project.Models.Base;

namespace ASP.NET_Project.Models
{
    public class Horse : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Sex { get; set; } = string.Empty;

        public string Breed { get; set; } = string.Empty;

        public string BirthDate { get; set; } = string.Empty;

        public Category Category { get; set; } = new Category();

        public RidingCenter RidingCenter { get; set; } = new RidingCenter();

        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public Guid RidingCenterId { get; set; }

        public Guid CategoryID { get; set; }

    }
}
