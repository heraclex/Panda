using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaBookStore.Service.Models
{
    public class CategoryModel : BaseModel
    {
        [StringLength(50, MinimumLength = 3)]
        public string CategoryName { get; set; }
    }
}
