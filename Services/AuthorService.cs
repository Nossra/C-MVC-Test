using mvctest.DataAccess;
using mvctest.DataAccess.AuthorImplementation;
using mvctest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvctest.Services.Author
{
    public class AuthorService : IAuthorDao
    {
        private IAuthorDao _dao;


        public AuthorService(IAuthorDao dao)
        {
            _dao = dao;
        }

        public void SetDao(IAuthorDao dao)
        {
            _dao = dao;
        }

        public void SaveAuthor(Models.Author author)
        {
            _dao.SaveAuthor(author);
        }

        public void DeleteAuthor(int id)
        {
            _dao.DeleteAuthor(id);
        }

        public void UpdateAuthor(Models.Author author)
        {
            _dao.UpdateAuthor(author);
        }

        public List<Models.Author> FindAuthors()
        {
            return _dao.FindAuthors();
        }

        public Models.Author FindAuthorById(int id)
        {
            return _dao.FindAuthorById(id);
        }
    }
}