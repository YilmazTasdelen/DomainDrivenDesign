using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Domain.Orders
{
    public sealed partial class Order : Entity
    {
        public Order(Guid id, string orderNumber, DateTime createDate, OrderStatusEnum status) : base(id)
        {
            OrderNumber = orderNumber;
            CreateDate = createDate;
            Status = status;
        }

        public string OrderNumber { get; private set; }
        public DateTime CreateDate { get; private set; }
        public OrderStatusEnum Status { get; private set; }
        public ICollection<OrderLine> OrderLines { get; private set; }

        public void CreateOrder(List<CreateOrderDto> createOrderDtos)
        {

            foreach (var item in createOrderDtos)
            {
                if (item.quantity < 1)
                {
                    throw new ArgumentException("Quantity must be greater than 0");
                }

                OrderLine orderLine = new(
                    Guid.NewGuid(),
                    Id,
                    item.productId,
                    item.quantity,
                    new(item.amaunt, Currency.FromCode(item.currency))
                    );
                OrderLines.Add(orderLine);
            }
        }

        public void RemoveOrderLine(Guid orderLineId)
        {
            var orderLine = OrderLines.FirstOrDefault(p => p.Id == orderLineId);
            if(orderLine is null)
            {
                throw new ArgumentException("OrderLine that you want to delete could not be found");
            }
            OrderLines.Remove(orderLine);
        }
    }
}

