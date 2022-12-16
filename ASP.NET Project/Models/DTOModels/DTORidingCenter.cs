﻿namespace ASP.NET_Project.Models.DTOModels
{
    public class DTORidingCenter
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Location Location { get; set; } = new Location();
    }
}
