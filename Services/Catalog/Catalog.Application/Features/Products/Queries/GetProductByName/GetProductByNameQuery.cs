using MediatR;

namespace Catalog.Application.Features.Products.Queries.GetProductByName;

public class GetProductByNameQuery : IRequest<GetProductByNameResponse>
{
    public string Name { get; set; }
}