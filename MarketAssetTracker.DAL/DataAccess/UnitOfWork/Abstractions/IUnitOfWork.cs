using MarketAssetTracker.DAL.DataAccess.Repositories.Abstractions;

namespace MarketAssetTracker.DAL.DataAccess.UnitOfWork.Abstractions;

public interface IUnitOfWork : IDisposable
{
    IPriceRepository PriceRepository { get; }
    IAssetRepository AssetRepository { get; }
    Task<int> SaveAsync();
}