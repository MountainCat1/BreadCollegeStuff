using CollegeApp.Entities;

namespace CollegeApp.Dtos;

public class DirectorDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
}


public static class DirectorDtoExtensions
{
    public static DirectorDto ToDto(this Director director)
    {
        return new DirectorDto()
        {
            Id = director.Id,
            FullName = director.FullName
        };
    }
}