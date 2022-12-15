using ASP.NET_Project.Models.Base;

namespace ASP.NET_Project.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty; 

        public int Price { get; set; } = 0;

        public List<Horse> Horses = new List<Horse>();
    }
}
