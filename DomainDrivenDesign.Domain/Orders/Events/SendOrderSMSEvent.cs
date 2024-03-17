using MediatR;

namespace DomainDrivenDesign.Domain.Orders.Events
{
    public sealed class SendOrderSMSEvent : INotificationHandler<OrderDomainEvent>
    {
        public Task Handle(OrderDomainEvent notification, CancellationToken cancellationToken)
        {
            // Send Sms Codes Here 
            return Task.CompletedTask;
        }
    }
}
