using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service.Profiles
{
    public class PrictureProfile : AutoMapper.Profile
    {
        public PrictureProfile()
        {
            CreateMap<Data.Entities.Picture, Models.PictureModel>();
            CreateMap<Models.PictureModel, Data.Entities.Picture>();
        }
    }
}
