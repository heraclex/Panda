using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service.Profiles
{
    public class BookProfile : AutoMapper.Profile
    {
        public BookProfile()
        {
            CreateMap<Data.Entities.Book, Models.BookModel>();
            CreateMap<Models.BookModel, Data.Entities.Book>();
        }
    }
}
