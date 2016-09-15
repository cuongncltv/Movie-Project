using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MovieProject.Areas.Admin.Code;
using MovieProject.Areas.Admin.Models;
using MovieProject.Models;

namespace MovieProject.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            if (Membership.ValidateUser(model.Email, model.Password) && ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.Email,model.RememberMe);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("","Sai tên đăng nhập hoặc mật khẩu.");
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Login");
        }
    }
}