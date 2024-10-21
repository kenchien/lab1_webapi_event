

using lab1_webapi_event.Entity;
using lab1_webapi_event.Common.Queries;
using lab1_webapi_event.Store;
using MediatR;

namespace lab1_webapi_event.Handler
{
    public class GetProductByIdHandler(MockDataStore mockDataStore) : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly MockDataStore _mockDataStore  = mockDataStore;

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _mockDataStore.GetProduct(request.id);
        }
    }
}
