using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaBookStore.Data.Entities
{
    public class Picture : BaseEntity
    {
        public byte[] PictureBinary { get; set; }
    }
}
