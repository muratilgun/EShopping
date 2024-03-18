using Catalog.Core.Specs;
using MediatR;

namespace Catalog.Application.Features.Products.Queries.GetAllProducts;

public class GetAllProductsQuery : IRequest<List<GetAllProductsResponse>>
{
    public CatalogSpecParams CatalogSpecParams { get; set; }

    public GetAllProductsQuery(CatalogSpecParams catalogSpecParams)
    {
        CatalogSpecParams = catalogSpecParams;
    }
}