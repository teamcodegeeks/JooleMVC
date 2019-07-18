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
    public class CompareController : Controller
    {
        public ActionResult CompareProduct()
        {
            long proId = 1;
            long proId1 = 2;
            int subcatid = 21;
            var temperatory = new CompareService();
         
            var table = from t1 in temperatory.Summary() where t1.ProductId == proId select t1;
           
            var table1 = from t1 in temperatory.Summary() where t1.ProductId == proId1 select t1;
            var templist = table.ToList().ToList();
           var templist1 = table1.ToList().ToList();

            List<CompareProducts> objproductinfo = new List<CompareProducts>();
            CompareProducts tempproduct1 = new CompareProducts();
            CompareProducts tempproduct2 = new CompareProducts();
            tempproduct1 = templist[0];
            tempproduct2 = templist1[0];
            objproductinfo.Add(tempproduct1);
            objproductinfo.Add(tempproduct2);
            var temp = objproductinfo.ToList();
            if (subcatid == 21)
            {
                return View("FanCompare", objproductinfo.ToList());
            }
            else if (subcatid == 22)
            {
                return View("VaccumCompare", objproductinfo.ToList());
            }
            else
            {
                return View("ToasterCompare", objproductinfo.ToList());
            }

        }
    }
}

