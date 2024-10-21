using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace lab1_webapi_event.Controllers;

[Route("api/[products]")]
[ApiController]
public class ProductsController(IMediator mediator) : ControllerBase
{
   private readonly IMediator _mediator = mediator;
}