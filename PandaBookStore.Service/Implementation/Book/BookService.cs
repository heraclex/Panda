using AutoMapper;
using PandaBookStore.Data;
using PandaBookStore.Data.Entities;
using PandaBookStore.Service.Common;
using PandaBookStore.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PandaBookStore.Service
{
    public class BookStoreService : ICustomerService
    {
        #region Constants
        #endregion

        #region Fields

        private readonly IRepository<Book> repository;

        #endregion

        #region Ctor

        public BookStoreService(IRepository<Book> repository)
        {
            this.repository = repository;
        }

        #endregion

        #region Books
        
        public BookModel InsertBook(BookModel model)
        {
            var entity = model.MapTo<Book>();

            this.repository.Insert(entity);

            return entity.MapTo<BookModel>();
        }

        public BookModel UpdateBook(BookModel model)
        {
            var entity = model.MapTo<Book>();

            this.repository.Update(entity);

            return entity.MapTo<BookModel>();
        }

        /// <summary>
        /// Delete a book
        /// </summary>
        /// <param name="book">Book</param>
        public void DeleteBook(BookModel model)
        {
            if (model == null)
                throw new ArgumentNullException("book");

            model.IsDeleted = true;
            var entity = model.MapTo<Book>();
            //delete book
            this.repository.Update(entity);

            //event notification
            //_eventPublisher.EntityDeleted(product);
        }

        public IList<BookModel> GetAllBooks()
        {
            var query = from b in this.repository.Table
                        orderby b.Id
                        where !b.IsDeleted 
                        select b;
            var results = query.ToList().MapTo<BookModel>();
            return results;
        }

        public BookModel GetBookById(int id)
        {
            var entity = this.repository.GetById(id);
            return entity.MapTo<BookModel>();
        }

        #endregion
    }
}
