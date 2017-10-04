using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service.Profiles
{
    public class CategoryProfile : AutoMapper.Profile
    {
        public CategoryProfile()
        {
            CreateMap<Data.Entities.Category, Models.CategoryModel>();
            CreateMap<Models.CategoryModel, Data.Entities.Category>();
        }
    }
}
