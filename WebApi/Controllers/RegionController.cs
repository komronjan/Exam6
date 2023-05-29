using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
using Infrastructure.Services;
namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RegionController : ControllerBase
{
    RegionService regionService;
    public RegionController()
    {
        regionService = new RegionService();
    }
    [HttpGet("GetAllRegion")]
    public List<RegionDto> GetAllRegions()
    {
        return regionService.GetAllRegion();
    }
    [HttpDelete("DeleteRegion")]
    public void DeleteRegion(int id)
    {
        regionService.DeleteRegion(id);
    }
    [HttpPost("addRegion")]
    public void AddRegion(RegionDto region)
    {
        regionService.AddRegion(region);
    }
}
