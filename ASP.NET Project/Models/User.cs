using ASP.NET_Project.Models.Base;

namespace ASP.NET_Project.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string BirthDate { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;
        
        public string Email { get; set; } = string.Empty;        

        public string Adress { get; set; } = string.Empty;

    }
}
