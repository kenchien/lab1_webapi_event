


using lab1_webapi_event.Common.Notification;
using lab1_webapi_event.Store;
using MediatR;

namespace lab1_webapi_event.Handler;

    public class SMSHandler(MockDataStore mockDataStore) : INotificationHandler<ProductAddedNotification>
    { 
         private readonly MockDataStore _mockDataStore = mockDataStore;

        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _mockDataStore.EventOccured(notification.Product, "SMS_EVENT");
            await Task.CompletedTask;
        }
    }
