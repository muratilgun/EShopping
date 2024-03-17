using AutoMapper;
using Catalog.Application.Services.IRepositories;
using MediatR;

namespace Catalog.Application.Features.Brands.Queries.GetAllBrands;

public class GetAllBrandsQueryHandler(IBrandRepository _brandRepository, IMapper _mapper)
    : IRequestHandler<GetAllBrandsQuery, IList<GetAllBrandsResponse>>
{
    public async Task<IList<GetAllBrandsResponse>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
    {

        var brands = await _brandRepository.GetAllBrands();
        var response = _mapper.Map<IList<GetAllBrandsResponse>>(brands);
        return response;
    }
}