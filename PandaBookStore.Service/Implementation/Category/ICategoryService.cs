using PandaBookStore.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service
{
    public interface ICategoryService : IService
    {
        CategoryModel InsertCategory(CategoryModel model);

        CategoryModel UpdateCategory(CategoryModel model);

        /// <summary>
        /// Delete a book
        /// </summary>
        /// <param name="book">Book</param>
        void DeleteCategory(CategoryModel model);

        /// <summary>
        /// GetAllBooks
        /// </summary>
        /// <returns></returns>
        IList<CategoryModel> GetAllCategories();

        /// <summary>
        /// GetBookById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CategoryModel GetCategoryById(int id);
    }
}
