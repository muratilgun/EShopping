using AutoMapper;
using Catalog.Application.Features.Products.Commands;

namespace Catalog.Application.Features.Products.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Core.Entities.Product, CreateProductResponse>().ReverseMap();
    }
    
}