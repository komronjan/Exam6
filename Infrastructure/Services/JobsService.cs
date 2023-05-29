namespace Infrastructure.Services;
using Dapper;
using Domain.Dtos;
using Infrastructure.Context;

public class JobsService
{
    DapperContext dapperContext;
    public JobsService()
    {
        dapperContext = new DapperContext();
    }
    public void AddJob(JobsDto job)
    {
        using (var conn = dapperContext.CreateConnection())
        {
            var sql = $"INSERT INTO jobs (job_title, min_salary,max_salary) VALUES(@JobTitle, @MinSalary, @MaxSalary)";
            var result = conn.Execute(sql, job);
        }
    }
    public List<JobsDto> GetAllJobs()
    {
        using (var conn = dapperContext.CreateConnection())
        {
            var sql = $"SELECT job_id as Id, job_title as JobTitle, min_salary as MinSalary, max_salary as MaxSalary FROM jobs;";
            var result = conn.Query<JobsDto>(sql);
            return result.ToList();
        }
    }
    public void DeleteJob(int id)
    {
        using (var conn = dapperContext.CreateConnection())
        {
            var sql = $"DELETE FROM jobs WHERE job_id = {id};";
            var result = conn.Execute(sql);
        }
    }
    public void UpdateJob(JobsDto job)
    {
        using (var conn = dapperContext.CreateConnection())
        {
            var sql = $"UPDATE jobs SET job_title='{job.JobTitle}', min_salary={job.MinSalary},max_salary={job.MaxSalary} FROM jobs where job_id={job.Id}";
            var result = conn.Execute(sql, job);
        }
    }
}
