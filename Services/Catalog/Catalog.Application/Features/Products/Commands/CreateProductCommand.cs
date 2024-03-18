using Catalog.Core.Entities;
using MediatR;
using Type = Catalog.Core.Entities.Type;

namespace Catalog.Application.Features.Products.Commands;

public class CreateProductCommand : IRequest<CreateProductResponse>
{
    public string Name { get; set; }
    public string Summary { get; set; }
    public string Description { get; set; }
    public string ImageFile { get; set; }
    public decimal Price { get; set; }
    public Brand Brands { get; set; }
    public Type Types { get; set; }
}