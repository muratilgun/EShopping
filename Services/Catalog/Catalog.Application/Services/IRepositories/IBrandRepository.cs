using Catalog.Core.Entities;

namespace Catalog.Application.Services.IRepositories;

public interface IBrandRepository
{
    Task<IEnumerable<Brand>> GetAllBrands();
}