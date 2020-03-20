using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web_Books.Data.Models;
using Web_Books.Service.Interfaces;

namespace Web_Books.Service.Services
{
    class LibraryService : ILibrary
    {
        void ILibrary.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void ILibrary.DeleteUserBooks(string username)
        {
            throw new NotImplementedException();
        }

        IQueryable<Book> ILibrary.GetAllBooks()
        {
            throw new NotImplementedException();
        }

        Book ILibrary.GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        IQueryable<Book> ILibrary.GetBooksByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        IQueryable<Book> ILibrary.GetBooksByUserName(string username)
        {
            throw new NotImplementedException();
        }
    }
}
