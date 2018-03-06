using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvctest.Models;

namespace mvctest.DataAccess.BookImplementation
{
    public class BookDbContextImpl : IBookDao
    {
        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> FindBooks()
        {
            throw new NotImplementedException();
        }

        public Book FindBookById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}