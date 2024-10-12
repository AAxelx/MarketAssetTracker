using MarketAssetTracker.DAL.DataAccess.Contexts;
using MarketAssetTracker.DAL.DataAccess.Repositories.Abstractions;
using MarketAssetTracker.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarketAssetTracker.DAL.DataAccess.Repositories;

public class AssetRepository : IAssetRepository
{
    private readonly MarketAssetTrackerDbContext _context;

    public AssetRepository(MarketAssetTrackerDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<AssetEntity>> GetAllAssetsAsync()
    {
        return await _context.Assets.ToListAsync();
    }
}