using Catalog.Application.Services.IRepositories;
using MediatR;

namespace Catalog.Application.Features.Products.Commands.DeleteProduct;

public class DeleteProductCommandHandler(IProductRepository productRepository)
    : IRequestHandler<DeleteProductCommand, bool>
{
 

    public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        await productRepository.DeleteProduct(request.Id);
        return true;
        
    }
}