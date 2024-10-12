using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarketAssetTracker.DAL.Entities.Configurations;

public class AssetConfiguration : IEntityTypeConfiguration<AssetEntity>
{
    public void Configure(EntityTypeBuilder<AssetEntity> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Symbol)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(a => a.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.Category)
            .HasMaxLength(50);

        builder.Property(a => a.CreatedAt)
            .IsRequired();
    }
}