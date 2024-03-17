using AutoMapper;
using Catalog.Application.Features.Brands.Queries.GetAllBrands;
using Catalog.Core.Entities;

namespace Catalog.Application.Features.Brands.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Brand, GetAllBrandsResponse>().ReverseMap();
    }
    
}