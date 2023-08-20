namespace CollegeApp.Entities;

public class PressForm
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    public DateTime InstallationDate { get; set; }

    public Guid WorkshopId { get; set; }
}