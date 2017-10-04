using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service.Profiles
{
    public class OrderProfile : AutoMapper.Profile
    {
        public OrderProfile()
        {
            CreateMap<Data.Entities.Order, Models.OrderModel>()
                .ForMember(dest=>dest.OrderItems, opt=>opt.MapFrom(src=>src.OrderItems));

            CreateMap<Models.OrderModel, Data.Entities.Order>()
                .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems));
        }
    }
}
