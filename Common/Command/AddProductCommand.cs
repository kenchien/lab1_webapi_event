

using lab1_webapi_event.Entity;
using MediatR;

namespace lab1_webapi_event.Common.Command;
   
public record AddProductCommand(Product AddProduct) : IRequest<Product>;