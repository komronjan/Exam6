namespace Infrastructure.Services;
using Dapper;
using Domain.Dtos;
using Infrastructure.Context;

public class CountriesService
{
     DapperContext dapperContext;
    public CountriesService()
    {
        dapperContext = new DapperContext();
    }
    public void AddCountries(CountriesDto country)
    {
        using (var conn = dapperContext.CreateConnection())
        {
            var sql = $"INSERT INTO Countries (country_name, region_id) VALUES(@CountryName, @RegionId)";
            var result = conn.Execute(sql, country);
        }
    }
    public List<CountriesDto> GetAllCountry()
    {
        using (var conn = dapperContext.CreateConnection())
        {
            var sql = $"SELECT country_id as Id, country_name as CountryName, region_id as RegiobId  FROM countries;";
            var result = conn.Query<CountriesDto>(sql);
            return result.ToList();
        }
    }
    public void DeleteCountry(int id)
    {
        using (var conn = dapperContext.CreateConnection())
        {
            var sql = $"DELETE FROM countries WHERE country_id = {id};";
            var result = conn.Execute(sql);
        }
    }

}
