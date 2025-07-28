using DomainDrivenDesign.Domain.Users.Event;
using MediatR;

public sealed class SendUserSmsEvent : INotificationHandler<UserDomainEvent>
{
    public Task Handle(UserDomainEvent notification, CancellationToken cancellationToken)
    {
        // SMS gönderme işlemi
        return Task.CompletedTask;
    }
}