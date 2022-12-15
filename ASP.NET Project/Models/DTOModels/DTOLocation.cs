namespace ASP.NET_Project.Models.DTOModels
{
    public class DTOLocation
    {
        public string Country { get; set; } = string.Empty;

        public string Region { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public int PostalCode { get; set; } = 0;

        public string Street { get; set; } = string.Empty;

        public int Number { get; set; } = 0;
    }
}
