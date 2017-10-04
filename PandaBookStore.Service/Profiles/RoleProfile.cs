using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service.Profiles
{
    public class RoleProfile : AutoMapper.Profile
    {
        public RoleProfile()
        {
            CreateMap<Data.Entities.Role, Models.RoleModel>();
            CreateMap<Models.RoleModel, Data.Entities.Role>();
        }
    }
}
