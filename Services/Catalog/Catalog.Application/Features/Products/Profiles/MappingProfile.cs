using AutoMapper;
using Catalog.Application.Features.Products.Commands;
using Catalog.Application.Features.Products.Commands.CreateProduct;

namespace Catalog.Application.Features.Products.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Core.Entities.Product, CreateProductResponse>().ReverseMap();
        CreateMap<Core.Entities.Product, CreateProductCommand>().ReverseMap();
    }
    
}