using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaBookStore.Service.Models
{
    public class OrderItemModel : BaseModel
    {
        public int BookId { get; set; }

        public int OrderId { get; set; }

        public int Quantity { get; set; }
        
        public virtual BookModel Book { get; set; }

        public virtual OrderModel Order { get; set; }
        
        public bool Remove { get; set; }
    }
}
