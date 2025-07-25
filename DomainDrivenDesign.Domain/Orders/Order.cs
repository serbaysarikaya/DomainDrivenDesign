namespace DomainDrivenDesign.Domain.Orders;

public sealed class Order
{
    public Guid Id { get; set; }
    public string OrderName { get; set; } = default!;
    public DateTimeOffset CreatedDAte { get; set; }
    public string Status { get; set; } = default!;
    public ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
}
