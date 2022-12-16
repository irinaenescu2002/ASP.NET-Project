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

        // Create new location - CREATE 

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

        // Show all locations - READ

        [HttpGet("Get Location")]
        public async Task<ActionResult<string>> GetLocations()
        {
            var allLocations = _ILocationService.Get();

            return Ok(allLocations);
        }

        // Update location by ID 

        [HttpPut("Update Location/{id}")]
        public async Task<ActionResult<string>> UpdateLocation(DTOLocation location, Guid id)
        {
            var ok = await _ILocationService.Update(location, id);

            if (ok) return Ok("Updated"); else return StatusCode(304);
        }

        // Delete location by id - DELETE 

        [HttpDelete("Delete Location/{id}")]
        public async Task<ActionResult<string>> DeleteLocation(Guid id)
        {
            await _ILocationService.Delete(id);

            return Ok("Location Deleted");
        }
    }
}
