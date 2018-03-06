using mvctest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvctest.DataAccess
{
    public interface IAuthorDao
    {
        void SaveAuthor(Author author);
        void DeleteAuthor(int id);
        void UpdateAuthor(Author author);
        List<Author> FindAuthors();
        Author FindAuthorById(int id);
    }
}
