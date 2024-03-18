using Catalog.Application.Services.IRepositories;
using MediatR;
using static Catalog.Application.Extensions.MapperExtensions;


namespace Catalog.Application.Features.Brands.Queries.GetAllBrands;

public class GetAllBrandsQueryHandler(IBrandRepository brandRepository)
    : IRequestHandler<GetAllBrandsQuery, IList<GetAllBrandsResponse>>
{
    public async Task<IList<GetAllBrandsResponse>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
    {

        var brands = await brandRepository.GetAllBrands();
        var response = LazyMapper.Map<IList<GetAllBrandsResponse>>(brands);
        return response;
    }
}