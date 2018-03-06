using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using mvctest.Models;

namespace mvctest.DataAccess.AuthorImplementation
{
    public class AuthorDbContextImpl : IAuthorDao
    {
        TestContext db = new TestContext();

        public void DeleteAuthor(int id)
        {
            Author author = db.Authors.Include("Books").SingleOrDefault(x => x.Id == id);
            
            if (author != null)
            {
                //List<Book> books = author.Books;
                //for (int i = 0; i < books.Count; i++)
                //{
                //    db.Books.Remove(books[i]);
                //}
                
                author.Books.Clear();
                db.Authors.Remove(author);
                db.SaveChanges();
            }
        }

        public Author FindAuthorById(int id)
        {
            return db.Authors.SingleOrDefault(x => x.Id == id);
        }

        public List<Author> FindAuthors()
        {
            List<Author> authors = db.Authors.ToList();
            return authors;
        }

        public void SaveAuthor(Author author)
        {
            db.Authors.Add(author);
            db.SaveChanges();
        }

        public void UpdateAuthor(Author author)
        {
            db.Entry(author).State = EntityState.Modified;
            db.SaveChanges();

        }
    }
}