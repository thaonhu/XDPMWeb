using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoAdminPPP.Models;
using System.Data.Entity;


namespace DemoAdminPPP.Controllers
{
    public class PPPController : Controller
    {
        private phuotppEntities db = new phuotppEntities();

        // GET: PPP
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.Publisher);
            return View(products.ToList());
        }

        public ActionResult SanPham()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.Publisher);

            return View(products.ToList());
        }

    }
}