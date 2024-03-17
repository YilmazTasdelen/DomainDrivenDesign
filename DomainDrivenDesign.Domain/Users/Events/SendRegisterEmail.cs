using MediatR;

namespace DomainDrivenDesign.Domain.Users.Events
{
    public sealed class SendRegisterEmail : INotificationHandler<UserDomainEvent>
    {
        public Task Handle(UserDomainEvent notification, CancellationToken cancellationToken)
        {
            //send email codes here 
            return Task.CompletedTask;
        }
    }
}
