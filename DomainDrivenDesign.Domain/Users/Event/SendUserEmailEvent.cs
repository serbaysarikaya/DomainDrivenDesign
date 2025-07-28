using DomainDrivenDesign.Domain.Users.Event;
using MediatR;

public sealed class SendUserEmailEvent : INotificationHandler<UserDomainEvent>
{
    public Task Handle(UserDomainEvent notification, CancellationToken cancellationToken)
    {
        // Email gönderme işlemi
        return Task.CompletedTask;
    }
}
