using MarketAssetTracker.DAL.DataAccess.Contexts;
using MarketAssetTracker.DAL.DataAccess.Repositories;
using MarketAssetTracker.DAL.DataAccess.Repositories.Abstractions;
using MarketAssetTracker.DAL.DataAccess.UnitOfWork;
using MarketAssetTracker.DAL.DataAccess.UnitOfWork.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace MarketAssetTracker.API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

        builder.Services.AddScoped<IAssetRepository, AssetRepository>();
        builder.Services.AddScoped<IPriceRepository, PriceRepository>();

        builder.Services.AddDbContext<MarketAssetTrackerDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("MSSQLConnection")));
        
        builder.Services.AddAuthorization();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.Run();
    }
}