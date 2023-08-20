namespace CollegeApp.Entities;

public class Workshop
{
    public Guid Id { get; set; } // PK
    
    public string Name { get; set; }
    
    public Guid DirectorId { get; set; } // FK
    public Guid SectorId { get; set; } // FK
}