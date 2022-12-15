using ASP.NET_Project.Models;
using ASP.NET_Project.Models.DTOModels;
using ASP.NET_Project.Repositories.Locations;
using ASP.NET_Project.Services.Locations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ASP.NET_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        public ILocationService _ILocationService;

        public LocationController(ILocationService iLocationService)
        {
            _ILocationService = iLocationService;
        }

        [HttpPost("Create Location")]
        public async Task<ActionResult<string>> CreateLocation(DTOLocation location)
        {
            var locationToCreate = new Location
            {
                Country = location.Country,
                Region = location.Region,
                City = location.City,
                PostalCode = location.PostalCode,
                Street = location.Street,
                Number = location.Number,
            };

            await _ILocationService.Create(locationToCreate);

            return Ok("Location Created");
        }
    }
}
