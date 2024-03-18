using AutoMapper;
using Catalog.Application.Services.IRepositories;
using MediatR;

namespace Catalog.Application.Features.Products.Queries.GetProductByBrandName;

public class
    GetProductByBrandNameQueryHandler : IRequestHandler<GetProductByBrandNameQuery,
    IEnumerable<GetProductByBrandNameResponse>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductByBrandNameQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetProductByBrandNameResponse>> Handle(GetProductByBrandNameQuery request,
        CancellationToken cancellationToken)
    {
        var productList = await _productRepository.GetProductByBrand(request.BrandName);
        return _mapper.Map<IEnumerable<GetProductByBrandNameResponse>>(productList);
    }
}