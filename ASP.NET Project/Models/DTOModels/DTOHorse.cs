namespace ASP.NET_Project.Models.DTOModels
{
    public class DTOHorse
    {
        public string Name { get; set; } = string.Empty;

        public string Sex { get; set; } = string.Empty;

        public string Breed { get; set; } = string.Empty;

        public string BirthDate { get; set; } = string.Empty;

        public Category Category { get; set; } = new Category();

        public RidingCenter RidingCenter { get; set; } = new RidingCenter();
    }
}
