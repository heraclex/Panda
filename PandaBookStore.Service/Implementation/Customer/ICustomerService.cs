using PandaBookStore.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBookStore.Service
{
    public interface ICustomerService : IService
    {
        CustomerModel InsertCustomer(CustomerModel model);

        CustomerModel UpdateCustomer(CustomerModel model);

        /// <summary>
        /// Delete a book
        /// </summary>
        /// <param name="book">Book</param>
        void DeleteCustomer(CustomerModel model);

        /// <summary>
        /// GetAllBooks
        /// </summary>
        /// <returns></returns>
        IList<CustomerModel> GetAllCustomers();

        /// <summary>
        /// GetBookById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CustomerModel GetCustomerById(int id);
    }
}
