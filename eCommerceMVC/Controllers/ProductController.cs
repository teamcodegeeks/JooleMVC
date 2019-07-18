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
            ProductService ps = new ProductService();
            List<Product> prod = new List<Product>();
            prod = ps.prodInfo(21);

            if (prod.Count > 0)
            {
                List<Product> listProduct = new List<Product>();
                foreach(var item in prod)
                {
                    Product product = new Product();
                    product.ProductId = item.ProductId;
                    product.ProductName = item.ProductName;
                    product.ModelTypeId = item.ModelTypeId;
                    product.SubCategoryId = item.SubCategoryId;
                    listProduct.Add(product);
                }

                ViewBag.product = listProduct.ToArray();
              //  ViewBag.product = new string[] { "teset", "tes2t", "Riddhi" };
            }
            return View("Product");
        }

        public ActionResult GetProduct()
        {
            return View("Product");
        }
    }
}