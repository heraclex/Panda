using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service.Profiles
{
    public class CommentProfile : AutoMapper.Profile
    {
        public CommentProfile()
        {
            CreateMap<Data.Entities.Comment, Models.CommentModel>();
            CreateMap<Models.CommentModel, Data.Entities.Comment>();
        }
    }
}
