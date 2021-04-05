using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DailyStatus.Models;

namespace DailyStatus.Controllers
{
    public class LoginController : Controller
    {
        private ContextFile DbContext;

        public LoginController()
        {
            DbContext = new ContextFile();
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login login)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", login);
            }
            Login data = DbContext.login.SingleOrDefault(m => m.Email.CompareTo(login.Email) == 0);
            if(data == null)
            {
                ViewBag.Status = "Not Registered";
                return View("Index", login);
            }
            if(data.Password.CompareTo(login.Password) != 0)
            {
                ViewBag.Status = "Wrong Credentials";
                login.Password = "";
                return View("Index", login);
            }
            Session["Email"] = login.Email;
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            Session["Email"] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}