namespace Infrastructure.Services;
using Dapper;
using Domain.Dtos;
using Infrastructure.Context;
public class LocationsService
{
    DapperContext dapperContext;
    public LocationsService()
    {
        dapperContext = new DapperContext();
    }
    
    public void AddLocation(LocationDto location)
    {
        using (var conn = dapperContext.CreateConnection())
        {
            var sql = $"INSERT INTO locations(street_address,postal_code,city,state_province,country_id)VALUES(@StreetAddress,@PostalCode,@City,@StateProvince,@CountryId)";
            var result = conn.Execute(sql, location);
        }
    }
     public List<LocationDto> GetAllLocations()
    {
        using (var conn = dapperContext.CreateConnection())
        {
            var sql = $"SELECT location_id as Id, street_address as StreetAddress, postal_code as ProvinceCode, city as City, state_province as StateProvince, country_id as CountryId from locations";
            var result = conn.Query<LocationDto>(sql);
            return result.ToList();
        }
    }
}
