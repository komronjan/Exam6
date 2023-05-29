using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
using Infrastructure.Services;
namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]

public class CountriesController : ControllerBase
{
    CountriesService countriesService;
    public CountriesController()
    {
        countriesService = new CountriesService();
    }
    [HttpGet("Getcountries")]
    public List<CountriesDto> GetCountries()
    {
        return countriesService.GetAllCountry();
    }
    [HttpDelete("Deletecountry")]
    public void DeleteCountry(int id)
    {
        countriesService.DeleteCountry(id);
    }
    [HttpPost("AddCountry")]
    public void AddCountry(CountriesDto country)
    {
        countriesService.AddCountries(country);
    }
}
