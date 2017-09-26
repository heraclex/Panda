using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
