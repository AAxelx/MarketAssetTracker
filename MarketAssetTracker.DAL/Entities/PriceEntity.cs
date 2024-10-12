namespace MarketAssetTracker.DAL.Entities;

public class PriceEntity
{
    public Guid Id { get; set; }
    public Guid AssetId { get; set; }
    public decimal Price { get; set; }
    public DateTime Timestamp { get; set; }

    public virtual AssetEntity Asset { get; set; }
}