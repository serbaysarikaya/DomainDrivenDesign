using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Shared;

namespace DomainDrivenDesign.Domain.Users;

public sealed class User : Entity
{
    private User(Guid id) : base(id)
    {

    }
    private User(Guid id, Name name, Email email, Password password, Address address) : base(id)
    {   Name = name;
        Email = email;
        Password = password;
        Address = address;
    }

    public Name Name { get; private set; } = default!;
    public Email Email { get; private set; } = default!;
    public Password Password { get; private set; } = default!;
    public Address Address { get; private set; } = default!;

    public static User CreateUser( string name, string email, string password, string country, string city, string street, string fullAddress, string postalCode)
    {
        return new User(
            id : Guid.NewGuid(),
            name:new (name),
            email: new (email), 
            password:new (password), 
           address: new Address(country, city, street, fullAddress, postalCode));
    }

    public void ChangeName(string name)
    {
        Name = new(name);
    }
    public void ChangePassword(string pasword)
    {
        Name = new(pasword);
    }
    public void ChangeEmail(string email)
    {
        Email = new(email);
    }
    public void ChangeAddress(string country, string city, string street,string fullAddress,string postalCode)
    {
        Address = new(country,city,street,fullAddress,postalCode);
    }

}
