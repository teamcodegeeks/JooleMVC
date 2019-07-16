using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;

namespace eCommerceMVC.Repository
{
    public class ProductTechSpecRepository:GenericRepository<ProductTechSpec>,IProductTechSpecRepository
    {
        private JoojleEntities _dbcontext;
        private DbSet<ProductTechSpec> dbset;
        public ProductTechSpecRepository(JoojleEntities dbcontext) : base(dbcontext)
        {
            this._dbcontext = dbcontext;
            this.dbset = _dbcontext.Set<ProductTechSpec>();
        }
    }
}