namespace Infrastructure.Context;
using System.Data;
using Npgsql;
public class DapperContext
{
    string connString = "Server = localhost; Port = 5432; Database= Exam6; User Id = postgres; Password = koma;";
    public DapperContext()
    {

    }
    public IDbConnection CreateConnection()
    {
        return new NpgsqlConnection(connString);
    }   
}
