using MediatR;

namespace DomainDrivenDesign.Domain.Users.Event
{
    public sealed class UserDomainEvent : INotification
    {
        public User User { get; }

        public UserDomainEvent(User user)
        {
            User = user;
        }
    }
}
