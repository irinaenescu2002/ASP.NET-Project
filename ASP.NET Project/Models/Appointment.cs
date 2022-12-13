using ASP.NET_Project.Models.Base;

namespace ASP.NET_Project.Models
{
    public class Appointment : BaseEntity
    {
        public string Date { get; set; } = string.Empty;

        public string StartTime { get; set; } = string.Empty;

        public string EndTime { get; set; } = string.Empty;

        public Horse Horse { get; set; } = new Horse();

        public User Person { get; set; } = new User();

        public Guid HorseId { get; set; }

        public Guid PersonId { get; set; }

    }
}
