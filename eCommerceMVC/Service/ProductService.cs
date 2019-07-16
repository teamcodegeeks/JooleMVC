using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;
using eCommerceMVC.UoW;


namespace eCommerceMVC.Service
{
    public class ProductService
    {
        Product productInfo = new Product();

        public List<Product> prodInfo(int prodCategoryId)
        {
            using (var unitofwork = new UnitofWork(new JoojleEntities()))
            {
                List<Product> product = unitofwork.ProductRepository.Get(
                    filter: p => p.SubCategoryId == prodCategoryId
                    ).ToList();

                if (product.Count != 0) return product;
                else return null;
            }
        }
    }
}