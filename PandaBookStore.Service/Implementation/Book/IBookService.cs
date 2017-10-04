using PandaBookStore.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service
{
    public interface IBookService : IService
    {
        BookModel InsertBook(BookModel model);

        BookModel UpdateBook(BookModel model);

        /// <summary>
        /// Delete a book
        /// </summary>
        /// <param name="book">Book</param>
        void DeleteBook(BookModel model);

        /// <summary>
        /// GetAllBooks
        /// </summary>
        /// <returns></returns>
        IList<BookModel> GetAllBooks();

        /// <summary>
        /// GetBookById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BookModel GetBookById(int id);
    }
}
