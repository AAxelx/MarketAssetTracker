using MarketAssetTracker.DAL.DataAccess.Contexts;
using MarketAssetTracker.DAL.DataAccess.Repositories.Abstractions;
using MarketAssetTracker.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarketAssetTracker.DAL.DataAccess.Repositories;

public class PriceRepository : IPriceRepository
{
    private readonly MarketAssetTrackerDbContext _context;

    public PriceRepository(MarketAssetTrackerDbContext context)
    {
        _context = context;
    }

    public async Task<PriceEntity> GetByIdAsync(Guid assetId)
    {
        return await _context.Prices
            .FirstOrDefaultAsync(p => p.AssetId == assetId);
    }

    public async Task<IEnumerable<PriceEntity>> GetByIdsAsync(IEnumerable<Guid> assetIds)
    {
        return await _context.Prices
            .Where(p => assetIds.Contains(p.AssetId))
            .ToListAsync();
    }
}