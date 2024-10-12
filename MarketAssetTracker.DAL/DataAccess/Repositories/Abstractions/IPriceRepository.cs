using MarketAssetTracker.DAL.Entities;

namespace MarketAssetTracker.DAL.DataAccess.Repositories.Abstractions;

public interface IPriceRepository
{
    Task<PriceEntity> GetByIdAsync(Guid assetId);
    Task<IEnumerable<PriceEntity>> GetByIdsAsync(IEnumerable<Guid> assetIds);
}