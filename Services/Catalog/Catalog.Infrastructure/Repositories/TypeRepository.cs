using Catalog.Application.Services.IRepositories;
using Catalog.Infrastructure.Data;
using MongoDB.Driver;
using Type = Catalog.Core.Entities.Type;

namespace Catalog.Infrastructure.Repositories;

public class TypeRepository(ICatalogContext context) : ITypeRepository
{
    public async Task<IEnumerable<Type>> GetAllTypes()
    {
        return await context
            .Types
            .Find(b => true)
            .ToListAsync();
    }
}