using MediatR;

namespace Catalog.Application.Features.Products.Queries.GetProductByBrandName;

public class GetProductByBrandNameQuery : IRequest<IEnumerable<GetProductByBrandNameResponse>>
{
    public string BrandName { get; set; }
    
}