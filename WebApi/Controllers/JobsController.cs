using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
using Infrastructure.Services;
namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class JobsController : ControllerBase
{
    JobsService jobService;
    public JobsController()
    {
        jobService = new JobsService();
    }
    [HttpPost("AddJob")]
    public void AddJob(JobsDto job)
    {
        jobService.AddJob(job);
    }
    [HttpGet("GetAllJobs")]
    public List<JobsDto> GetJobs()
    {
        return jobService.GetAllJobs();
    }
    [HttpDelete("DeleteJob")]
    public void DeleteJob(int id)
    {
        jobService.DeleteJob(id);
    }
    [HttpPut("UpdateJob")]
    public void UpdateJob(JobsDto job)
    {
        jobService.UpdateJob(job);
    }
}
