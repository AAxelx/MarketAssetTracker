using MarketAssetTracker.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarketAssetTracker.DAL.DataAccess.Contexts;

public class MarketAssetTrackerDbContext : DbContext
{
    public DbSet<AssetEntity> Assets { get; set; }
    public DbSet<PriceEntity> Prices { get; set; }

    public MarketAssetTrackerDbContext(DbContextOptions<MarketAssetTrackerDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MarketAssetTrackerDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}