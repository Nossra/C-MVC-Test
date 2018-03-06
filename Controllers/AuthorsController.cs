using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mvctest.DataAccess.AuthorImplementation;
using mvctest.Models;
using mvctest.Services.Author;

namespace mvctest.Controllers
{
    public class AuthorsController : Controller
    {
        private TestContext db = new TestContext();
        AuthorService authorService = new AuthorService(new AuthorDbContextImpl());

        public ActionResult Index()
        {
            return View(authorService.FindAuthors());
        }

        public ActionResult Details(int id)
        {
            Author author = authorService.FindAuthorById(id);
            return View(author);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author author) //[Bind(Include = "Id,Name,Age")] 
        {
            if (ModelState.IsValid)
            {
                authorService.SaveAuthor(author);
                return RedirectToAction("Index");
            }

            return View(author);
        }

        public ActionResult Edit(int id)
        {
            Author author = authorService.FindAuthorById(id);
            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age")] Author author)
        {
            if (ModelState.IsValid)
            {
                authorService.UpdateAuthor(author);
                return RedirectToAction("Index");
            }
            return View(author);
        }

        public ActionResult Delete(int id)
        {
            Author author = authorService.FindAuthorById(id);
            return View(author);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            authorService.DeleteAuthor(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
