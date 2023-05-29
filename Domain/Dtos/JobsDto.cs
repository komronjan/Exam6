namespace Domain.Dtos;

public class JobsDto
{
    public int Id { get; set; }
    public string JobTitle { get; set; }
    public int MinSalary { get; set; }
    public int MaxSalary { get; set; }
}
