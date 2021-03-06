﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaBookStore.Data.Entities
{
    public class Customer : BaseEntity
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

        public string HowContactYou { get; set; }

        public string HearUs { get; set; }

        //public string CreditCardNumber { get; set; }

        //public string CardExpiredDate { get; set; }

        public bool Subscribe { get; set; }

        public bool Active { get; set; }

        public int RoleId { get; set; }

        public virtual Role Role { get; set; }

        public virtual List<Comment> Recommendations { get; set; }
    }
}
