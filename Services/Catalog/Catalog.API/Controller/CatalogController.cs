using Catalog.Application.Features.Products.Queries.GetProductById;
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
}