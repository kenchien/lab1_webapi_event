using lab1_webapi_event.Entity;
using lab1_webapi_event.Common.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using lab1_webapi_event.Common.Command;

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

   [HttpPost]
public async Task<IResult> AddProduct([FromBody]Product p)
   {
      Product pro = await _mediator.Send(new AddProductCommand(p));
      return Results.Ok(pro);
   }

   //public async Task<IActionResult> AddProduct([FromBody]Product p)
   //{
   //   await _mediator.Send(new AddProductCommand(p));
   //   return StatusCode(201);
   //}

  [HttpGet("{id:int}",Name ="GetProductById")]
   public async Task<IActionResult> GetProduct([FromRoute]int id)
   {
      Product p = await _mediator.Send(new GetProductByIdQuery(id));

      return Ok(p);
   }
}