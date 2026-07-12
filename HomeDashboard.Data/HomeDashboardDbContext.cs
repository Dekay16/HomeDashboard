using HomeDashboard.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeDashboard.Data.Context;

public class HomeDashboardDbContext : DbContext
{
    public HomeDashboardDbContext(
        DbContextOptions<HomeDashboardDbContext> options)
        : base(options)
    {
    }


    public DbSet<Room> Rooms { get; set; }

    public DbSet<PaintColor> PaintColors { get; set; }

    public DbSet<Appliance> Appliances { get; set; }

    public DbSet<Measurement> Measurements { get; set; }

    public DbSet<Vehicle> Vehicles { get; set; }

    public DbSet<VehicleMaintenance> VehicleMaintenance { get; set; }

    public DbSet<MaintenanceItem> MaintenanceItems { get; set; }

    public DbSet<Reminder> Reminders { get; set; }

    public DbSet<Document> Documents { get; set; }

    public DbSet<Photo> Photos { get; set; }

    public DbSet<InventoryItem> InventoryItems { get; set; }

    public DbSet<Note> Notes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}