using MarketAssetTracker.DAL.DataAccess.Contexts;
using MarketAssetTracker.DAL.DataAccess.Repositories;
using MarketAssetTracker.DAL.DataAccess.Repositories.Abstractions;
using MarketAssetTracker.DAL.DataAccess.UnitOfWork.Abstractions;

namespace MarketAssetTracker.DAL.DataAccess.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly MarketAssetTrackerDbContext _context;
    private IPriceRepository _priceRepository;
    private IAssetRepository _assetRepository;

    public UnitOfWork(MarketAssetTrackerDbContext context)
    {
        _context = context;
    }

    public IPriceRepository PriceRepository => 
        _priceRepository ??= new PriceRepository(_context);

    public IAssetRepository AssetRepository => 
        _assetRepository ??= new AssetRepository(_context);

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}