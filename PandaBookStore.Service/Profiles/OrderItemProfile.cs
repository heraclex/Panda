using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service.Profiles
{
    public class OrderItemProfile : AutoMapper.Profile
    {
        public OrderItemProfile()
        {
            CreateMap<Data.Entities.OrderItem, Models.OrderItemModel>();
            CreateMap<Models.OrderItemModel, Data.Entities.OrderItem>();
        }
    }
}
