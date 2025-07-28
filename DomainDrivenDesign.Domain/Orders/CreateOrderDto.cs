namespace DomainDrivenDesign.Domain.Orders;

public sealed record CreateOrderDto(
    Guid ProductId,
    int Quantity,
    decimal Amoun,
    string Currency);