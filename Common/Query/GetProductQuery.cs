
using lab1_webapi_event.Entity;
using MediatR;

namespace lab1_webapi_event.Common.Queries;

    public record GetProductQuery : IRequest<IEnumerable<Product>>;


