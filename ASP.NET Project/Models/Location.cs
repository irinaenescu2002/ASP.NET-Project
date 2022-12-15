using ASP.NET_Project.Models.Base;

namespace ASP.NET_Project.Models
{
    public class Location : BaseEntity
    {
        public string Country { get; set; } = string.Empty;

        public string Region { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;

        public string Street { get; set; } = string.Empty;

        public string Number { get; set; } = string.Empty;

        public RidingCenter RidingCenter { get; set; } = new RidingCenter();
    }
}
