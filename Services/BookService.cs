using mvctest.DataAccess.BookImplementation;
using mvctest.Models;
using System;
using System.Collections.Generic;

namespace mvctest.Services
{
    public class BookService : IBookDao
    {
        private IBookDao _dao = new BookDbContextImpl();

        public void DeleteBook(int id)
        {
            _dao.DeleteBook(id);
        }

        public List<Book> FindBooks()
        {
            return _dao.FindBooks();
        }

        public Book FindBookById(int id)
        {
            return _dao.FindBookById(id);
        }

        public void SaveBook(Book book)
        {
            _dao.SaveBook(book);
        }

        public void UpdateBook(Book book)
        {
            _dao.UpdateBook(book);
        }
    }
}