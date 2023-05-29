using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
using Infrastructure.Services;
namespace WebApi.Controllers;
public class LocationsController : ControllerBase
{
    LocationsService locationsService;
    public LocationsController()
    {
        locationsService = new LocationsService();
    }
    [HttpGet("GetLocations")]
    public List<LocationDto> GetLocations()
    {
        return locationsService.GetAllLocations();
    }
    [HttpPost("addLocation")]
    public void AddLocation(LocationDto location)
    {
        locationsService.AddLocation(location);
    }
}
