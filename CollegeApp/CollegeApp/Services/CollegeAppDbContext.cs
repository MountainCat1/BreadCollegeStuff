using CollegeApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CollegeApp.Services;

public class CollegeAppDbContext : DbContext
{
    public DbSet<Director> Directors { get; set; } = null!;
    public DbSet<Workshop> Workshops { get; set; } = null!;
    public DbSet<Sector> Sectors { get; set; } = null!;
    public DbSet<PressForm> PressForms { get; set; } = null!;
    public DbSet<Repair> Repairs { get; set; } = null!;
    public DbSet<Repairman> Repairmen { get; set; } = null!;
    
    public CollegeAppDbContext(DbContextOptions options) : base(options)
    {
        //Sexy stuff happening in here ;)
    }
    
    protected override void OnModelCreating(ModelBuilder mb)
    {
        var directorModel = mb.Entity<Director>();
        directorModel.HasKey(x => x.Id);
        directorModel.Property(x => x.FullName);

        var workshopModel = mb.Entity<Workshop>();
        workshopModel.HasKey(x => x.Id);
        workshopModel.HasOne<Director>()
            .WithMany()
            .HasForeignKey(x => x.DirectorId);
        workshopModel.HasOne<Sector>()
            .WithMany()
            .HasForeignKey(x => x.SectorId);

        var sectorModel = mb.Entity<Sector>();
        sectorModel.HasKey(x => x.Id);
        
        var pressFormModel = mb.Entity<PressForm>();
        pressFormModel.HasKey(x => x.Id);
        pressFormModel.HasOne<Workshop>()
            .WithMany()
            .HasForeignKey(x => x.WorkshopId);

        var repairModel = mb.Entity<Repair>();
        repairModel.HasKey(x => x.Id);
        repairModel.HasOne<PressForm>()
            .WithMany()
            .HasForeignKey(x => x.PressFormId);

        repairModel.HasOne<Repairman>()
            .WithMany()
            .HasForeignKey(x => x.RepairmenId);
        
        var repairmenModel = mb.Entity<Repairman>();
        repairmenModel.HasKey(x => x.Id);
        
        
        base.OnModelCreating(mb);
    }
}