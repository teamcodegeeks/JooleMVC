using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;
using eCommerceMVC.Service;
using eCommerceMVC.UoW;

namespace eCommerceMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View("login");
        }
        [HttpPost]
        public ActionResult LoginUser() {
            UserServicecs user = new UserServicecs();
            string username = Request["UserName"].ToString().ToLower();
            string password = Request["UserPassword"].ToString();
            User tempuser = new User();
            tempuser = user.userinfo(username);
            Session["tempuser"] = tempuser;
            if (user.Login(password))
            {
                Console.WriteLine("FIND !");
                Session["error"] = 0;
                return View();
            }
            else {
                Console.WriteLine("ERROR !");
                Session["error"] = 1;
                if (Convert.ToInt32(Session["error"]) == 1) ViewData["erroeinfo"] = "Please check login credentials!!";
                else ViewData["errorinfo"] = "";
                return View("Login");
            }
        }
        [HttpPost]
        public ActionResult Register() {
            UserServicecs user = new UserServicecs();
            string name = Request["newusername"].ToString().ToLower();
            string email = Request["newuseremail"].ToString().ToLower();
            string password = Request["newuserpassword"].ToString();
            user.register(name, email, password);
            return View();
        }
    }
}