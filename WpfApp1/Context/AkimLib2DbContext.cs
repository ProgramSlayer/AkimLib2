using AkimLib2.Core.Entities.Intruder;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1.Context;

public class AkimLib2DbContext : DbContext
{
    public DbSet<Intruder> Intruders => Set<Intruder>();

    public AkimLib2DbContext() { }
    public AkimLib2DbContext(DbContextOptions<AkimLib2DbContext> options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        //optionsBuilder.UseSqlite("data source = akim_lib_2.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Intruder>(b =>
        {
            b.ToTable("Intruder");

            b.HasKey(b => b.Id);

            b.OwnsOne(b => b.AccomplicesParams);
            b.OwnsOne(b => b.CarParams);
            b.OwnsOne(b => b.ComplexionParams);
            b.OwnsOne(b => b.OsnL);
            b.OwnsOne(b => b.OsnM);
            b.OwnsOne(b => b.OsnH);
            b.OwnsOne(b => b.PsychophysicalParams);
            b.OwnsOne(b => b.VelocityParams);
        });
    }
}