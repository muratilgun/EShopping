using Catalog.Application.Extensions;
using Catalog.Application.Services.IRepositories;
using MediatR;

namespace Catalog.Application.Features.Products.Queries.GetProductById;

public class GetProductByIdQueryHandler(IProductRepository productRepository)
    : IRequestHandler<GetProductByIdQuery, GetProductByIdResponse>
{


    public async Task<GetProductByIdResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await productRepository.GetProductAsync(request.Id);
        var response = MapperExtensions.LazyMapper.Map<GetProductByIdResponse>(product);
        return response;
    }
}