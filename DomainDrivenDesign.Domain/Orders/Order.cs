using DomainDrivenDesign.Domain.Abstractions;

namespace DomainDrivenDesign.Domain.Orders;

public sealed class Order:Entity
{
    public Order(Guid id,string orderName, DateTimeOffset createdDAte, string status, ICollection<OrderLine> orderLines) : base(id)
    {
        OrderName = orderName;
        CreatedDAte = createdDAte;
        Status = status;
        OrderLines = orderLines;
    }

    public string OrderName { get; private set; } = default!;
    public DateTimeOffset CreatedDAte { get; private set; }
    public string Status { get; private set; } = default!;
    public ICollection<OrderLine> OrderLines { get; private set; } = new List<OrderLine>();
}
