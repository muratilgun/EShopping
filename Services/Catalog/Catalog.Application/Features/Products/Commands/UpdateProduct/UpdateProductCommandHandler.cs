using Catalog.Application.Services.IRepositories;
using Catalog.Core.Entities;
using MediatR;

namespace Catalog.Application.Features.Products.Commands.UpdateProduct;

public class UpdateProductCommandHandler(IProductRepository productRepository)
    : IRequestHandler<UpdateProductCommand, bool>
{

    public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Id = request.Id,
            Name = request.Name,
            Summary = request.Summary,
            Description = request.Description,
            ImageFile = request.ImageFile,
            Price = request.Price,
            Brands = request.Brands,
            Types = request.Types
        };
        await productRepository.UpdateProduct(product);
        return true;
    }
}