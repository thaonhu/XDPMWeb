using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoAdminPPP.Models;


namespace DemoAdminPPP.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangnhap(User ac)
        {
            if (ModelState.IsValid)
            {
                String n = ac.users_name;
                String p = ac.users_password;
                var user = new UsersController();
                var res = user.Login(n, p);
                if (res)
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    //return View(n);
                    ModelState.AddModelError("", "không đăng nhập đc");
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }
    }
}