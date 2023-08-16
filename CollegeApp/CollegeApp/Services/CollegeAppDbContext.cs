using CollegeApp.Entities;
using Microsoft.EntityFrameworkCore;
using CollegeApp.Dtos;

namespace CollegeApp.Services;

public class CollegeAppDbContext : DbContext
{
    public DbSet<Director> Directors { get; set; } = null!;
    public DbSet<Workshop> Workshops { get; set; } = null!;
    
    public CollegeAppDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder mb)
    {
        var directorModel = mb.Entity<Director>();
        directorModel.HasKey(x => x.Id);
        directorModel.Property(x => x.FullName);

        var workshopModel = mb.Entity<Workshop>();
        workshopModel.HasKey(x => x.Section);
        workshopModel.HasOne<Director>(x => x.Director)
            .WithMany(x => x.Workshops)
            .HasForeignKey(x => x.DirectorId);
        
        base.OnModelCreating(mb);
    }
}