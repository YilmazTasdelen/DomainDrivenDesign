using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Domain.Orders
{
    public sealed class Order
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public OrderStatusEnum Status {  get; set; }
    }
}
