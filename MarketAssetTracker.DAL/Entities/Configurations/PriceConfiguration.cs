using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarketAssetTracker.DAL.Entities.Configurations;

public class PriceConfiguration : IEntityTypeConfiguration<PriceEntity>
{
    public void Configure(EntityTypeBuilder<PriceEntity> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Price)
            .IsRequired();

        builder.Property(p => p.Timestamp)
            .IsRequired();

        builder.HasOne<AssetEntity>()
            .WithMany()
            .HasForeignKey(p => p.AssetId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}