namespace ASP.NET_Project.Models.DTOModels
{
    public class DTOAppointment
    {
        public string Date { get; set; } = string.Empty;

        public string StartTime { get; set; } = string.Empty;

        public string EndTime { get; set; } = string.Empty;

        public Horse Horse { get; set; } = new Horse();

        public User Person { get; set; } = new User();
    }
}
