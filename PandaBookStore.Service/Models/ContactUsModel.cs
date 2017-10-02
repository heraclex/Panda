using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service.Models
{
    public class ContactUsModel : BaseModel
    {
        public string EmailAddress { get; set; }

        public string Name { get; set; }

        public string Message { get; set; }
    }
}
