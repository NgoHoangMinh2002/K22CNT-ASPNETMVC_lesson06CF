using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NhmLesson06CF.Models;

namespace NhmLesson06CF.Controllers
{
    public class NhmBooksController : Controller
    {
        private NhmBookstore db = new NhmBookstore();

        // GET: NhmBooks
        public ActionResult Index()
        {
            return View(db.NhmBooks.ToList());
        }

        // GET: NhmBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhmBook nhmBook = db.NhmBooks.Find(id);
            if (nhmBook == null)
            {
                return HttpNotFound();
            }
            return View(nhmBook);
        }

        // GET: NhmBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhmBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NhmID,NhmBookId,NhmTitle,NhmAuthor,NhmYear,NhmPulisher,NhmPicture,NhmCategoryId")] NhmBook nhmBook)
        {
            if (ModelState.IsValid)
            {
                db.NhmBooks.Add(nhmBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhmBook);
        }

        // GET: NhmBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhmBook nhmBook = db.NhmBooks.Find(id);
            if (nhmBook == null)
            {
                return HttpNotFound();
            }
            return View(nhmBook);
        }

        // POST: NhmBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NhmID,NhmBookId,NhmTitle,NhmAuthor,NhmYear,NhmPulisher,NhmPicture,NhmCategoryId")] NhmBook nhmBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhmBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhmBook);
        }

        // GET: NhmBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhmBook nhmBook = db.NhmBooks.Find(id);
            if (nhmBook == null)
            {
                return HttpNotFound();
            }
            return View(nhmBook);
        }

        // POST: NhmBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhmBook nhmBook = db.NhmBooks.Find(id);
            db.NhmBooks.Remove(nhmBook);
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
