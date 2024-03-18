using Catalog.Application.Extensions;
using Catalog.Application.Services.IRepositories;
using Catalog.Core.Entities;
using MediatR;

namespace Catalog.Application.Features.Products.Queries.GetProductByName;

public class GetProductByNameQueryHandler(IProductRepository productRepository)
    : IRequestHandler<GetProductByNameQuery, GetProductByNameResponse>
{
    public async Task<GetProductByNameResponse> Handle(GetProductByNameQuery request, CancellationToken cancellationToken)
    {
        var product = await productRepository.GetProductByName(request.Name);
        var response = MapperExtensions.LazyMapper.Map<GetProductByNameResponse>(product);
        return response;
    }
    
}