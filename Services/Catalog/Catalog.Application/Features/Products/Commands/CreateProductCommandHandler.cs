using Catalog.Application.Extensions;
using Catalog.Application.Services.IRepositories;
using Catalog.Core.Entities;
using MediatR;
using static Catalog.Application.Extensions.MapperExtensions;


namespace Catalog.Application.Features.Products.Commands;

public class CreateProductCommandHandler(IProductRepository productRepository)
    : IRequestHandler<CreateProductCommand, CreateProductResponse>
{
    private readonly IProductRepository _productRepository = productRepository;

    public async Task<CreateProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = MapperExtensions.LazyMapper.Map<Product>(request);
        if (product is null)
        {
            throw new ApplicationException("There was an error mapping the product");
        }
        var newProduct = await _productRepository.CreateProduct(product);
        var productResponse = LazyMapper.Map<CreateProductResponse>(newProduct);
        return productResponse;
    }
}