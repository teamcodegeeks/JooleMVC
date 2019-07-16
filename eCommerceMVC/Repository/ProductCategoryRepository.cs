using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;

namespace eCommerceMVC.Repository
{
    public class ProductCategoryRepository: GenericRepository<ProductCategory>,IProductCategoryRepository
    {
        private JoojleEntities _dbcontext;
        private DbSet<ProductCategory> dbset;
        public ProductCategoryRepository(JoojleEntities dbcontext) : base(dbcontext)
        {
            this._dbcontext = dbcontext;
            this.dbset = _dbcontext.Set<ProductCategory>();
        }
    }
}