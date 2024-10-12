namespace MarketAssetTracker.DAL.Entities;

public class AssetEntity
{
    public Guid Id { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public DateTime CreatedAt { get; set; }
}