using mvctest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvctest.DataAccess.BookImplementation
{
    interface IBookDao
    {
        void SaveBook(Book book);
        void DeleteBook(int id);
        void UpdateBook(Book book);
        List<Book> FindBooks();
        Book FindBookById(int id);
    }
}
