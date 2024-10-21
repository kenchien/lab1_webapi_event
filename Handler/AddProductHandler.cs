
using lab1_webapi_event.Common.Command;
using lab1_webapi_event.Entity;
using lab1_webapi_event.Store;
using MediatR;

namespace lab1_webapi_event.Handlers;

    public class AddProductHandler(MockDataStore mockDataStore) : IRequestHandler<AddProductCommand,Product>
    {
private readonly MockDataStore _mockDataStore = mockDataStore;
        
        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _mockDataStore.AddProduct(request.AddProduct);
            return request.AddProduct;
        }
        //public async Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        //{
        //    await _mockDataStore.AddProduct(request.AddProduct);
        //    return ;
        //}
    }
