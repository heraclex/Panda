using AutoMapper;
using PandaBookStore.Data;
using PandaBookStore.Data.Entities;
using PandaBookStore.Service.Common;
using PandaBookStore.Service.Models;
using System;
using System.Linq;

namespace PandaBookStore.Service
{
    public class BookStoreService : IBookService
    {
        public BookStoreService(IRepository<Book> bookRepo)
        {
            var books = bookRepo.Table.ToList();
            var result = books.MapTo<BookModel>();
        }
    }
}
