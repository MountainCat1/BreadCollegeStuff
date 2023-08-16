using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeApp.Entities;

public class Workshop
{
    public string Section { get; set; }
    
    public string Name { get; set; }
    
    public Guid DirectorId { get; set; }

    public virtual Director? Director { get; set; } 
}