using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service.Profiles
{
    public class CustomerProfile : AutoMapper.Profile
    {
        public CustomerProfile()
        {
            CreateMap<Data.Entities.Customer, Models.CustomerModel>();
            CreateMap<Models.CustomerModel, Data.Entities.Customer>();
        }
    }
}
