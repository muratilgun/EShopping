using Type = Catalog.Core.Entities.Type;

namespace Catalog.Application.Services.IRepositories;

public interface ITypeRepository
{
    Task<IEnumerable<Type>> GetAllTypes();
}