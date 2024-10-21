using lab1_webapi_event.Entity;
using lab1_webapi_event.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace lab1_webapi_event.Controllers;

[Route("api/products")]
[ApiController]
public class ProductsController(IMediator mediator) : ControllerBase
{
   private readonly IMediator _mediator = mediator;


   [HttpGet]
   public async Task<IActionResult> GetProducts()
   {
      IEnumerable<Product> products = await _mediator.Send(new GetProductQuery());

      return Ok(products);
   }
}