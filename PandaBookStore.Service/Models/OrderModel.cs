using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PandaBookStore.Service.Models
{
    public class OrderModel : BaseModel
    {
        public int CustomerId { get; set; }

        public decimal TotalPrice { get; set; }

        public int OrderStatusId { get; set; }

        public int PaymentStatusId { get; set; }

        public virtual CustomerModel Customer { get; set; }

        public virtual List<OrderItemModel> OrderItems { get; set; }
    }
}
