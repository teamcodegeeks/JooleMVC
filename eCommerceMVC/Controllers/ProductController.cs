using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerceMVC.Service;
using eCommerceMVC.Models;
using eCommerceMVC.ViewModels;


namespace eCommerceMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [HttpPost]
        public ActionResult Product(int _SubcategoryId)
        {
            int subId = _SubcategoryId;
            var temperatory = new ProductSummaryService();
            var table = from t1 in temperatory.Summary() where t1.SubCategoryId == subId select t1;
            var templist = table.ToList().ToList();
            ProductServicecs spec = new ProductServicecs();
            List<SpecFilter> speclist = spec.getspecfilter(subId);
            ViewBag.SpecFilter = speclist;

            List<int> listSubid = new List<int>();
            List<string> listPropname = new List<string>();
            List<int> listMin = new List<int>();
            List<int> listMax = new List<int>();

            for(int i = 0; i < speclist.Count; i++)
            {
                listSubid.Add(speclist[i].SubCategoryId);
                listPropname.Add(speclist[i].PropertyName);
                listMin.Add(speclist[i].MIN);
                listMax.Add(speclist[i].MAX);
            }
            ViewBag.Subid = listSubid;
            ViewBag.Prop = listPropname;
            ViewBag.Min = listMin;
            ViewBag.Max = listMax;


            return View("Product",templist);
        }
        //public ActionResult Filter()
        //{
        //    int subId = 21;
        //    ProductServicecs spec = new ProductServicecs();
        //    List<SpecFilter> specFilter = new List<SpecFilter>();
        //    specFilter = spec.getspecfilter(subId);
        //    return View();
        //}
    }
}