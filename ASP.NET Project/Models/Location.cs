using ASP.NET_Project.Models.Base;

namespace ASP.NET_Project.Models
{
    public class Location : BaseEntity
    {
        public string Country { get; set; } = string.Empty;

        public string Region { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public int PostalCode { get; set; } = 0;

        public string Street { get; set; } = string.Empty;

        public int Number { get; set; } = 0;

        public RidingCenter RidingCenter { get; set; } = default!;
    }
}
