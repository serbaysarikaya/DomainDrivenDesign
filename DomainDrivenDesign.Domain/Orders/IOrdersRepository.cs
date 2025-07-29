namespace DomainDrivenDesign.Domain.Orders
{
    public interface IOrdersRepository
    {
        Task<Order> CreateAsync(List<CreateOrderDto> createOrderDtos,CancellationToken cancellationToken =default);
        Task<List<Order>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
