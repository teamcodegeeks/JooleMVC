using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerceMVC.Repository;
using eCommerceMVC.Models;
using System.Data.Entity;

namespace eCommerceMVC.Repository
{
    public class ProductSubCategoryRepository:GenericRepository<ProductSubCategory>, IProductSubCategoryRepository
    {
        private JoojleEntities _dbcontext;
        private DbSet<ProductSubCategory> dbset;
        public ProductSubCategoryRepository(JoojleEntities dbcontext) : base(dbcontext)
        {
            this._dbcontext = dbcontext;
            this.dbset = _dbcontext.Set<ProductSubCategory>();
        }
    }
}