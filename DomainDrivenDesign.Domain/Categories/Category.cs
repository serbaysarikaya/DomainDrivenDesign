using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Products;
using DomainDrivenDesign.Domain.Shared;

namespace DomainDrivenDesign.Domain.Categories;

public sealed class Category : Entity
{
    private Category(Guid id) : base(id)
    {

    }
    public Category(Name name, Guid id) : base(id)
    {
        Name = name;
    }

    public Name Name { get; private set; } = default!;
    public ICollection<Product> Products { get; private set; } = new List<Product>();

    public void ChangeName(string name)
    {
        Name = new(name);
    }
}
