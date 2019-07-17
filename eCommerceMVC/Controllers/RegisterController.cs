using eCommerceMVC.Models;
using eCommerceMVC.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerceMVC.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View("Register");
        }


        [HttpPost]
        public ActionResult Register(User uc, HttpPostedFileBase file = null)
        {
            try
            {
                UserServicecs user = new UserServicecs();
                string name = Request["newusername"].ToString().ToLower();
                string email = Request["newuseremail"].ToString().ToLower();
                string password = Request["newuserpassword"].ToString();
                if (file != null && file.ContentLength > 0)
                {
                    string filename = Path.GetFileName(file.FileName);
                    string imgPath = Path.Combine(Server.MapPath("~/Images/ProfileImages/"), filename);
                    file.SaveAs(imgPath);
                }
                string imgUrl = "~/Images/ProfileImages/" + file.FileName;
                user.register(name, email, password, imgUrl);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return View();
        }


    }
}