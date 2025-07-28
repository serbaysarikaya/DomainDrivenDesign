using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Shared;

namespace DomainDrivenDesign.Domain.Orders;

public sealed class Order : Entity
{
    public Order(Guid id, string orderName, DateTimeOffset createdDAte, string status) : base(id)
    {
        OrderName = orderName;
        CreatedDAte = createdDAte;
        Status = status;
    }

    public string OrderName { get; private set; } = default!;
    public DateTimeOffset CreatedDAte { get; private set; }
    public string Status { get; private set; } = default!;
    public ICollection<OrderLine> OrderLines { get; private set; } = new List<OrderLine>();

    public void CreateOrder(List<CreateOrderDto> createOrderDtos)
    {
        foreach (var createOrderDto in createOrderDtos)
        {
            if (createOrderDto.Quantity < 1)
            {
                throw new ArgumentException("Sipariş Adeti bir den az olamaz.", nameof(createOrderDto.Quantity));
            }

            var orderLine = new OrderLine(
                Guid.NewGuid(),
                Id,
                createOrderDto.ProductId,
                createOrderDto.Quantity, new(createOrderDto.Amoun, Currency.FromCode(createOrderDto.Currency)));

            OrderLines.Add(orderLine);
        }
    }
    public void RemoveOrderLine(Guid orderLineId)
    {
        var orderLine = OrderLines.FirstOrDefault(ol => ol.Id == orderLineId);
        if (orderLine == null)
        {
            throw new ArgumentException("Order line not found.", nameof(orderLineId));
        }
        OrderLines.Remove(orderLine);
    }
}
