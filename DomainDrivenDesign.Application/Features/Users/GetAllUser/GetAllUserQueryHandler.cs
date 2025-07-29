using DomainDrivenDesign.Application.Features.Users.GetAllUser;
using DomainDrivenDesign.Domain.Users;
using MediatR;

internal class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, List<User>>
{
    private readonly IUsersRepository _usersRepository;

    public GetAllUserQueryHandler(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public Task<List<User>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
    {
       return _usersRepository.GetAllAsync(cancellationToken);
    }
}

