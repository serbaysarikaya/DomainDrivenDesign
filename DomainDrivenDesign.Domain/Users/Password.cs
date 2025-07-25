namespace DomainDrivenDesign.Domain.Users;

public sealed record Password
{
    public string Value { get; init; }
    public Password(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Parola alanı boş olamaz");
        }
        if (value.Length < 6)
        {
            throw new ArgumentException("Parola en az 6 karakterden oluşmalıdır!");
        }

        Value = value;
    }
}
