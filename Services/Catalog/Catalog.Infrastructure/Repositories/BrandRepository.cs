using Catalog.Application.Services.IRepositories;
using Catalog.Core.Entities;
using Catalog.Infrastructure.Data;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Repositories;

public class BrandRepository(ICatalogContext context) : IBrandRepository
{
    public async Task<IEnumerable<Brand>> GetAllBrands()
    {
        return await context
            .Brands
            .Find(b => true)
            .ToListAsync();
    }
}