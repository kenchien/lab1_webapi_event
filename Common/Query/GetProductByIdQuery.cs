
using lab1_webapi_event.Entity;
using MediatR;

namespace lab1_webapi_event.Common.Queries;

    public record GetProductByIdQuery(int id) : IRequest<Product>;


