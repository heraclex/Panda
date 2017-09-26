using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Data.Entities
{
    public class CustomerRole : BaseEntity
    {
        public int CustomerId { get; set; }

        public int RoleId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Role Role { get; set; }
    }
}
