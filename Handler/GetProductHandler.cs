

using lab1_webapi_event.Entity;
using lab1_webapi_event.Common.Queries;
using lab1_webapi_event.Store;
using MediatR;

namespace lab1_webapi_event.Handler
{
    public class GetProductHandler(MockDataStore mockDataStore) : IRequestHandler<GetProductQuery, IEnumerable<Product>>
    {
        private readonly MockDataStore _mockDataStore  = mockDataStore;

        public async Task<IEnumerable<Product>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await _mockDataStore.GetProducts();
        }
    }
}
