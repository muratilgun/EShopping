using MediatR;

namespace Catalog.Application.Features.Products.Commands.DeleteProduct;

public class DeleteProductCommand  : IRequest<bool>
{
    public string Id { get; set; }
    
}