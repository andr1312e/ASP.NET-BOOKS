using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Books.Data.Models;

namespace Web_Books.Service.Interfaces
{
    interface ILibrary
    {
        IQueryable<Book> GetAllBooks();
        Book GetBookById(int id);
        IQueryable<Book> GetBooksByCategory(Category category);
        IQueryable<Book> GetBooksByUserName(string username);
        void Delete(int id);
        void DeleteUserBooks(string username);
    }
}


