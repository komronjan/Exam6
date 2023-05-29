namespace Domain.Dtos;

public class LocationDto
{
    public int Id { get; set; }
    public string StreetAddress { get; set; }
    public int PostalCode { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public int CountryId{ get; set; }
}
