using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerceMVC.ViewModels;
using eCommerceMVC.Models;
using eCommerceMVC.Service;

namespace eCommerceMVC.Controllers
{
    public class ProductSummaryController : Controller
    {
        // GET: ProductSummay
        public ActionResult ProductSummary()
        {
            long proId = 1;
            var temperatory = new ProductSummaryService();
            var table = from t1 in temperatory.Summary() where t1.ProductId == proId select t1;
            var templist = table.ToList().ToList();
            Session["tempproduct"] = new ProductSummary();
            ProductSummary temp = (ProductSummary)Session["tempproduct"];
            if (templist[0].SubCategoryId == 21)
                return View("FanSummary", templist[0]);
            else if (temp.SubCategoryId == 22)
                return View("VacuumSummary");
            else if (temp.SubCategoryId == 23)
                return View("ToasterSummary");
            else return View();
        }
    }
}