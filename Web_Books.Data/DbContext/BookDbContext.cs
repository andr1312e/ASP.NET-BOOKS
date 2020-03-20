using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Web_Books.Data.Models;

namespace Web_Books.Data.DbContext
{
    public class BookDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { set; get; }
        public DbSet<Category> Categories { set; get; }
            
    }
}
