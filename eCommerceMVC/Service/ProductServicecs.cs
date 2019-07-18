using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerceMVC.UoW;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;

namespace eCommerceMVC.Service
{
    public class ProductServicecs
    {
        public List<SpecFilter> getspecfilter(int SubId) {
            var unitofwork = new UnitofWork(new JoojleEntities());
            List<SpecFilter> listspec = unitofwork.SpecFilterRepository.Get(
                filter: t => t.SubCategoryId == SubId
                ).ToList();
            if (listspec.Count() != 0) return listspec;
            return null;
        }
    }
}