
using lab1_webapi_event.Entity;
using MediatR;

namespace lab1_webapi_event.Queries
{
    public record GetProductQuery : IRequest<IEnumerable<Product>>;


}