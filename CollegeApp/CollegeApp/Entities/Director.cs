namespace CollegeApp.Entities;

public class Director
{
    public Guid Id { get; set; }
    public string FullName { get; set; }


    public virtual ICollection<Workshop>? Workshops { get; set; }
}