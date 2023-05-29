namespace Infrastructure.Services;
using Dapper;
using Domain.Dtos;
using Infrastructure.Context;
public class RegionService
{
        DapperContext dapperContext;
    public RegionService()
    {
        dapperContext = new DapperContext();
    }
    public void AddRegion(RegionDto region)
    {
        using (var conn = dapperContext.CreateConnection())
        {
            var sql = $"INSERT INTO regions (region_name) VALUES(@RegionName)";
            var result = conn.Execute(sql,region);
        }
    }
    public List<RegionDto> GetAllRegion()
    {
        using (var conn = dapperContext.CreateConnection())
        {
            var sql = $"SELECT region_id as Id, region_name as RegionName from regions";
            var result = conn.Query<RegionDto>(sql);
            return result.ToList();
        }
    }
    public void DeleteRegion(int id)
    {
        using (var conn = dapperContext.CreateConnection())
        {
            var sql = $"DELETE FROM regions WHERE region_id = {id};";
            var result = conn.Execute(sql);
        }
    }
}
