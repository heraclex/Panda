using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaBookStore.Data.Entities
{
    public class Comment : BaseEntity
    {
        [StringLength(1000, MinimumLength = 5)]
        public string Content {get;set;}

        public int CustomerId { get; set; }

        public int? BookId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Book Book { get; set; }
    }
}
