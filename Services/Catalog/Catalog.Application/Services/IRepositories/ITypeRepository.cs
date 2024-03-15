namespace Catalog.Application.Services.IRepositories;

public interface ITypeRepository
{
    Task<IEnumerable<Type>> GetAllTypes();
}