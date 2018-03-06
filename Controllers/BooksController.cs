using mvctest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace mvctest.Controllers
{
    public class BooksController : Controller
    {
        private TestContext db = new TestContext();

        // GET: Authors
        public ActionResult Index()
        {
            return View(db.Books.Include("Authors").ToList());
        }

        // GET: Authors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Include("Authors")
                .SingleOrDefault(x => x.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // GET: Authors/Create
        public ActionResult Create()
        {
            CreateBookViewModel vm = new CreateBookViewModel();
            vm.Authors = db.Authors.ToList();
            return View(vm);
        }

        // POST: Authors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book, int AuthId) //[Bind(Include = "Id,Name,Age")]
        {

            Author authorTemp = db.Authors.Find(AuthId);
            book.Authors = authorTemp;
           if (authorTemp != null)
            {
                if (ModelState.IsValid)
                {
                    book.Authors = authorTemp;
                    db.Books.Add(book);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(book);
        }

        // GET: Authors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Include("Authors")
                .SingleOrDefault(x => x.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Authors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book) //[Bind(Include = "Id,Name,Age")]
        {
            if (ModelState.IsValid)
            {
                var temp = db.Books.Include("Authors")
                .SingleOrDefault(x => x.Id == book.Id);
                temp.Title = book.Title;
                temp.Pages = book.Pages;
                temp.Authors.Name = book.Authors.Name;
                //db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: Authors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Include("Authors")
                .SingleOrDefault(x => x.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Authors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Include("Authors")
                .SingleOrDefault(x => x.Id == id);
            db.Books.Remove(book);
            db.SaveChanges();
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
