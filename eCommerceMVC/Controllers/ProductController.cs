using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerceMVC.Service;
using eCommerceMVC.Models;


namespace eCommerceMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View("Product");
        }

        public ActionResult GetProduct()
        {
            ProductService ps = new ProductService();
            List<Product> prod = new List<Product>();
            prod = ps.prodInfo(21);

            if (prod.Count > 0)
            {
                ViewBag.product = prod;
            }
            return View("Product");
        }
    }
}