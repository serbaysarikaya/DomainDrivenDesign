namespace DomainDrivenDesign.Domain.Users;

public sealed record Email
{
    public string Value { get; init; }
    public Email(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Email alanı boş olamaz");
        }
        if (!value.Contains("@") || !value.Contains("."))
        {
            throw new ArgumentException("Geçersiz email formatı!");
        }
        Value = value;
    }
}
