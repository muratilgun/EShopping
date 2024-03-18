using MediatR;

namespace Catalog.Application.Features.Products.Queries.GetProductById;

public class GetProductByIdQuery : IRequest<GetProductByIdResponse>
{
    public string Id { get; set; }
    
}