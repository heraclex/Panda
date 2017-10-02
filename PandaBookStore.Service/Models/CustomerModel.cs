using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service.Models
{
    public class CustomerModel : BaseModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Surburb { get; set; }

        public string Zipcode { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public bool Subscribe { get; set; }

        public bool Active { get; set; }

        public int RoleId { get; set; }

        public virtual RoleModel Role { get; set; }
    }
}
