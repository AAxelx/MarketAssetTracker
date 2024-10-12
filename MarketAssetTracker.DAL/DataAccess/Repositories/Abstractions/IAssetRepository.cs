using MarketAssetTracker.DAL.Entities;

namespace MarketAssetTracker.DAL.DataAccess.Repositories.Abstractions;

public interface IAssetRepository
{
    Task<IEnumerable<AssetEntity>> GetAllAssetsAsync();
}