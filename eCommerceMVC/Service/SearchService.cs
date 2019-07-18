using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerceMVC.Models;
using eCommerceMVC.UoW;
using System.Web.Caching;
using System.Collections;

namespace eCommerceMVC.Service
{
    public class SearchService
    {
        //private static JoojleEntities _dbcontext;
        private static Hashtable _cache = new Hashtable();
        public SearchService(
            //JoojleEntities dbcontext
            )
        {
           // _dbcontext = dbcontext;
        }
        public List<ProductCategory> GetCategoryName()
        {
            List<String> CategorynameList;
            List<ProductCategory> CategorynameObj;
            //using (var unitofwork = new UnitofWork(_dbcontext))
            var unitofwork = new UnitofWork(new JoojleEntities());
            //{
                CategorynameObj = unitofwork.ProductCategoryRepository.GetAll().ToList();
                CategorynameList = (from o in CategorynameObj
                                    select o.CategoryName.ToString()).ToList();

            //}
            return CategorynameObj;
        }

        //try to use;
        //public List<String> GetSubCategoryName(int id)
        //{
        //    List<String> SubCategorynameList;
        //    List<ProductSubCategory> SubCategorynameObj;
        //    if (_cache.Contains("search") == false)
        //    {
        //        System.Diagnostics.Debug.WriteLine(_cache.Contains("search"));

        //        using(var unitofwork = new UnitofWork(_dbcontext))
        //        {
        //            SubCategorynameObj = unitofwork.ProductSubCategoryRepository.GetAll().ToList();
        //            SubCategorynameList = (from o in SubCategorynameObj
        //                                   select o.SubCategoryName.ToString()).ToList();
        //            _cache.Add("search", SubCategorynameList);
        //        }
        //    }
        //    else
        //    {
        //        SubCategorynameList = (List<string>)_cache["search"];
        //    }
        //    System.Diagnostics.Debug.WriteLine(SubCategorynameList);

        //    return SubCategorynameList;
        //}

        //check from subcategoryName
        public List<String> GetSubCategoryNameWOCache(int id)
        {
            List<String> SubCategorynameList;
            IEnumerable<ProductSubCategory> SubCategorynameObj;

            System.Diagnostics.Debug.WriteLine("Category id passed:"+id);
            var unitofwork = new UnitofWork(new JoojleEntities());
            SubCategorynameObj = unitofwork.ProductSubCategoryRepository.GetAll().ToList();

            if (id == 0)
            {
                SubCategorynameList = (from o in SubCategorynameObj
                                       select o.SubCategoryName.ToString()).ToList();
            }
            else
            {
                SubCategorynameList = (from o in SubCategorynameObj
                                       where o.CategoryId == id
                                       select o.SubCategoryName.ToString()).ToList();
            }
            return SubCategorynameList;
        }


        //check from subcategory table
        public IEnumerable<ProductSubCategory> GetSubCategoryWOCache()
        {
            
            IEnumerable<ProductSubCategory> SubCategoryObj;

            //System.Diagnostics.Debug.WriteLine("Category id passed:" + id);
            using (var unitofwork = new UnitofWork(new JoojleEntities()))
            {
                SubCategoryObj = unitofwork.ProductSubCategoryRepository.GetAll().ToList();

                //if (id == 0)
                //{
                //    SubCategorynameList = (from o in SubCategorynameObj
                //                           select o.SubCategoryName.ToString()).ToList();
                //}
                //else
                //{
                //    SubCategorynameList = (from o in SubCategorynameObj
                //                           where o.CategoryId == id
                //                           select o.SubCategoryName.ToString()),o.Subcategor;
                //}
                return SubCategoryObj;
            }
        }





        //private bool disposed = false;
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //        if (disposing)
        //            _dbcontext.Dispose();
        //    this.disposed = true;
        //}
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
    }
}