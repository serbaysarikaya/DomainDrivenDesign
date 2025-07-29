using DomainDrivenDesign.Domain.Orders;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Orders.GetAllOrder;

internal sealed record GetAllOrderQuery():IRequest<List<Order>>;  
