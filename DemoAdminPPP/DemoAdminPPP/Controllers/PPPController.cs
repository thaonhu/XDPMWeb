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
            ViewBag.product = db.Products;
            ViewBag.img = db.Images;
            return View();
        }
        // GET: link
        [HttpGet]
        public ActionResult Timkiem(string tukhoa)
        {
            ViewBag.product = db.Products;
            ViewBag.img = db.Images;
            var links = from l in db.Products // lấy toàn bộ sản phẩm
                        select l;
            if (!String.IsNullOrEmpty(tukhoa)) // kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
                links = links.Where(s => s.product_name.Contains(tukhoa)); //lọc theo chuỗi tìm kiếm
            }
            return View(links);
        }
        public ActionResult ViewProduct()
        {
            ViewBag.product = db.Products;
            ViewBag.img = db.Images;
            return View();
        }
        public ActionResult SanPham()
        {
            ViewBag.product = db.Products;
            ViewBag.img = db.Images;
            return View();
        }
        public ActionResult GangTay()
        {
            ViewBag.product = db.Products;
            ViewBag.img = db.Images;
            return View();
        }
        public ActionResult ViewDetail(string id)
        {
            if (id == null)
            {
                return Redirect(Url.Action("Sanpham", "PPP"));
            }
            ViewBag.product = db.Products.Find(id);
            if (db.Products.Find(id) == null)
            {
                return View("Err");
            }
            ViewBag.img = db.Images;
            return View();
        }
        public ActionResult DatHang()
        {  
            return View();
        }
        //public ActionResult ThemGioHang(String id)
        //{
        //    Product p = db.Products.Find(id);
        //    DSSP old = (DSSP)Session["SanPham"];
        //    Session.Remove("Sanpham");
        //    DSSP dSSP = new DSSP(old);
        //    dSSP.
        //    return View();
        //}

    }
}