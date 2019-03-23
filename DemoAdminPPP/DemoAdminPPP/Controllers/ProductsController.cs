using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DemoAdminPPP.Models;

namespace DemoAdminPPP.Controllers
{
    public class ProductsController : Controller
    {
        private phuotppEntities db = new phuotppEntities();

        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.Publisher);
            return View(products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.category_id = new SelectList(db.Categories, "category_id", "category_name");
            ViewBag.publisher_id = new SelectList(db.Publishers, "publisher_id", "publisher_name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "product_id,product_name,product_description,price,publisher_id,category_id")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.category_id = new SelectList(db.Categories, "category_id", "category_name", product.category_id);
            ViewBag.publisher_id = new SelectList(db.Publishers, "publisher_id", "publisher_name", product.publisher_id);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.category_id = new SelectList(db.Categories, "category_id", "category_name", product.category_id);
            ViewBag.publisher_id = new SelectList(db.Publishers, "publisher_id", "publisher_name", product.publisher_id);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "product_id,product_name,product_description,price,publisher_id,category_id")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.category_id = new SelectList(db.Categories, "category_id", "category_name", product.category_id);
            ViewBag.publisher_id = new SelectList(db.Publishers, "publisher_id", "publisher_name", product.publisher_id);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
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
