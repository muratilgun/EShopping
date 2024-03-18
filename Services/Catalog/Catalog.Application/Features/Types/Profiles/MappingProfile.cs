using AutoMapper;
using Catalog.Application.Features.Types.Queries.GetAllTypes;
using Type = Catalog.Core.Entities.Type;

namespace Catalog.Application.Features.Types.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Type, GetAllTypesResponse>().ReverseMap();
    }
    
}