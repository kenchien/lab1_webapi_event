using lab1_webapi_event.Entity;
using MediatR;

namespace lab1_webapi_event.Common.Notification
{
   public record ProductAddedNotification(Product Product) : INotification;
   
}