using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using eCommerceMVC.Models;
using eCommerceMVC.Service;


namespace eCommerceMVC.Controllers
{
    public class SearchController : Controller
    { 

        //search page
        public ActionResult Search()
        {

            List<ProductCategory> listname;
            //using (SearchService category = new SearchService(new JoojleEntities()))
            SearchService category = new SearchService();
            {
                listname = category.GetCategoryName();
            }
            TempData["Cate"] = listname;
            TempData.Keep("Cate");
            return View(listname);
        }


        //[ChildActionOnly]
        //public PartialViewResult GetSearchBar()
        //{
        //    List<ProductCategory> listname;
        //    using (SearchService category = new SearchService(new JoojleEntities()))
        //    {
        //        listname = category.GetCategoryName();
        //    }
        //    TempData["Cate"] = listname;
        //    TempData.Keep("Cate");


        //    return PartialView("~/Views/Shared/_Searchbarpartial.cshtml", listname);
        //}


        //Json for autocomplete 
        //[OutputCache(Duration = 60)]
        [HttpPost]
        public JsonResult AutoComplete(string search, int _categoryId)
        {
            List<String> listofsubcate;

            System.Diagnostics.Debug.WriteLine("autocomplete:"+search + " and " + _categoryId);
            SearchService subcategory = new SearchService();
            {
                //listofsubcate = subcategory.GetSubCategoryName(_categoryId); //with cache TODO
                listofsubcate = subcategory.GetSubCategoryNameWOCache(_categoryId);
            }
            //var result = data.Where(x => x.ToLower().StartsWith(search.ToLower()));
            var listsearchresult = listofsubcate.Where(x => x.ToLower().StartsWith(search.ToLower()));

            return Json(listsearchresult, JsonRequestBehavior.AllowGet);
            //return Json(result, JsonRequestBehavior.AllowGet);
        }

        //[OutputCache(Duration = 60)]
        //[HttpPost]
        //public JsonResult AutoComplete(string search, int _categoryId)
        //{
        //    List<String> listofsubcate;

        //    System.Diagnostics.Debug.WriteLine(search + " and " + _categoryId);
        //    using (SearchService subcategory = new SearchService(new JooleEntities1()))
        //    {
        //        //listofsubcate = subcategory.GetSubCategoryName(_categoryId); //with cache TODO
        //        listofsubcate = subcategory.GetSubCategoryNameWOCache(_categoryId);
        //    }



        //    //var result = data.Where(x => x.ToLower().StartsWith(search.ToLower()));
        //    var listsearchresult = listofsubcate.Where(x => x.ToLower().StartsWith(search.ToLower()));

        //    return Json(listsearchresult, JsonRequestBehavior.AllowGet);
        //    //return Json(result, JsonRequestBehavior.AllowGet);
        //}

        //pass search result to server side; //check valid and go;
        [HttpPost]
        public ActionResult ShowSearch(int categoryid, string searchstring)
        {
            System.Diagnostics.Debug.WriteLine("search info typed by user:categoryid:"+categoryid +" string:"+ searchstring);
            IEnumerable<ProductSubCategory> listofsubcateObj;
            SearchService subcategoryservice = new SearchService();
            listofsubcateObj = subcategoryservice.GetSubCategoryWOCache();
            bool isFound = false;
            int selectedSubcategoryId = -1;
            //seach everything in certain value;
            foreach (var subcate in listofsubcateObj)
            {
                if (subcate.SubCategoryName.Equals(searchstring))
                {
                    isFound = true;
                    selectedSubcategoryId = subcate.SubCategoryId;
                }

            }
            //Based on compare go different page
            if (isFound)
            {
                TempData["result"] = categoryid;
                System.Diagnostics.Debug.WriteLine("Enter controller");

                return RedirectToAction("Product", "Product", new { _SubcategoryId = selectedSubcategoryId });

            }
            else
            {
                //TODO: input is wrong
                return RedirectToAction("FilterPage","Filter");
            }
        }




        }
}

