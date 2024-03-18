using Catalog.Application.Extensions;
using Catalog.Application.Services.IRepositories;
using MediatR;

namespace Catalog.Application.Features.Products.Queries.GetAllProducts;


public class GetAllProductsQueryHandler(IProductRepository productRepository)
    : IRequestHandler<GetAllProductsQuery, List<GetAllProductsResponse>>
{

    public async Task<List<GetAllProductsResponse>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await productRepository.GetProducts(request.CatalogSpecParams);
        var response = MapperExtensions.LazyMapper.Map<List<GetAllProductsResponse>>(products);
        return response;
    }
}