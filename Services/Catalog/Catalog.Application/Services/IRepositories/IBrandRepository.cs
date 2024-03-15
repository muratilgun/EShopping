using Catalog.Core.Entities;

namespace Catalog.Application.Services.IRepositories;

public interface IBrandRepository
{
    Task<IEnumerable<Brand>> GetBrands();
    Task<Brand> GetBrandById(string id);
    Task<Brand> CreateBrand(Brand brand);
    Task<bool> UpdateBrand(Brand brand);
    Task<bool> DeleteBrand(string id);
    
}