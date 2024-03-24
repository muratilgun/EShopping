using Catalog.Application.Features.Brands.Queries.GetAllBrands;
using Catalog.Application.Features.Products.Commands.CreateProduct;
using Catalog.Application.Features.Products.Commands.DeleteProduct;
using Catalog.Application.Features.Products.Commands.UpdateProduct;
using Catalog.Application.Features.Products.Queries.GetAllProducts;
using Catalog.Application.Features.Products.Queries.GetProductByBrandName;
using Catalog.Application.Features.Products.Queries.GetProductById;
using Catalog.Application.Features.Products.Queries.GetProductByName;
using Catalog.Application.Features.Types.Queries.GetAllTypes;
using Catalog.Core.Specs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controller;

public class CatalogController : ApiController
{
    
    private readonly IMediator _mediator;

    public CatalogController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    [Route("[action]/{id}", Name = "GetProductById")]
    [ProducesResponseType(typeof(GetProductByIdResponse), StatusCodes.Status200OK)]
    public async Task<ActionResult<GetProductByIdResponse>> GetProductById(string id)
    {
        var query = new GetProductByIdQuery() {Id = id};
        var result = await _mediator.Send(query);
        return Ok(result);
    }
    
    [HttpGet]
    [Route("[action]/{productName}", Name = "GetProductByName")]
    [ProducesResponseType(typeof(GetProductByNameResponse), StatusCodes.Status200OK)]
    public async Task<ActionResult<GetProductByNameResponse>> GetProductByName(string productName)
    {
        var query = new GetProductByNameQuery() {Name = productName};
        var result = await _mediator.Send(query);
        return Ok(result);
    }
  [HttpGet]
    [Route("GetAllProducts")]
    [ProducesResponseType(typeof(IList<GetAllProductsResponse>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IList<GetAllProductsResponse>>> GetAllProducts([FromQuery]CatalogSpecParams catalogSpecParams)
    {

            var query = new GetAllProductsQuery(catalogSpecParams);
            var result = await _mediator.Send(query);
            return Ok(result);

    }
    
    [HttpGet]
    [Route("GetAllBrands")]
    [ProducesResponseType(typeof(IList<GetAllBrandsResponse>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IList<GetAllBrandsResponse>>> GetAllBrands()
    {
        var query = new GetAllBrandsQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }
    
    [HttpGet]
    [Route("GetAllTypes")]
    [ProducesResponseType(typeof(IList<GetAllTypesResponse>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IList<GetAllTypesResponse>>> GetAllTypes()
    {
        var query = new GetAllTypesQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }
    
    [HttpGet]
    [Route("[action]/{brand}", Name = "GetProductsByBrandName")]
    [ProducesResponseType(typeof(IList<GetAllProductsResponse>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IList<GetAllProductsResponse>>> GetProductsByBrandName(string brand)
    {
        var query = new GetProductByBrandNameQuery() {BrandName = brand};
        var result = await _mediator.Send(query);
        return Ok(result);
    }
    
    [HttpPost]
    [Route( "CreateProduct")]
    [ProducesResponseType(typeof(CreateProductResponse), StatusCodes.Status200OK)]
    public async Task<ActionResult<CreateProductResponse>> CreateProduct([FromBody] CreateProductCommand productCommand)
    {
        var result = await _mediator.Send(productCommand);
        return Ok(result);
    }
    
    [HttpPut]
    [Route( "UpdateProduct")]
    [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
    public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductCommand productCommand)
    {
        var result = await _mediator.Send(productCommand);
        return Ok(result);
    }
    [HttpDelete]
    [Route("{id}",Name="DeleteProduct")]
    [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
    public async Task<IActionResult> DeleteProduct(string id)
    {
        var query = new DeleteProductCommand{Id = id};
        var result = await _mediator.Send(query);
        return Ok(result);
    }
}