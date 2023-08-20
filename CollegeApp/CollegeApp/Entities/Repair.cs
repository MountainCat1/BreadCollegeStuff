namespace CollegeApp.Entities;

public class Repair
{
    public Guid Id { get; set; } // PK

    public DateTime Date { get; set; }
    
    public Guid RepairmenId { get; set; } // FK
    public Guid PressFormId { get; set; } // FK
}