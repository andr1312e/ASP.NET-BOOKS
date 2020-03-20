using System;
using System.Collections.Generic;

namespace Web_Books.Data.Models
{
    public class Book
    {
        public int BookId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public IEnumerable<Category> Categories { set; get; }
        public string ImagePath { set; get; }
        public string PDFPath { set; get; }
        public string UserName { set; get; }
        public DateTime dateTime { set; get; }
    }
}
