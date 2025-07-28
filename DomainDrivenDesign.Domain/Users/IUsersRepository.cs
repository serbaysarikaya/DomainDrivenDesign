namespace DomainDrivenDesign.Domain.Users
{
    public interface IUsersRepository
    {
        Task CreateAsyc(string name, string email, string password, string country, string city, string street, string fullAddress, string postalCode,CancellationToken cancellationToken =default);
        Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
