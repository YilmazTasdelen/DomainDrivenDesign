namespace DomainDrivenDesign.Domain.Orders
{
    public sealed partial class Order
    {
        public sealed record CreateOrderDto(
            Guid productId,
            int quantity,
            decimal amaunt,
            string currency
            );
    }
}

