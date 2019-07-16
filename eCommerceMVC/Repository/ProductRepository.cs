using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;

namespace eCommerceMVC.Repository
{
    public class ProductRepository:GenericRepository<Product>, IProductRepository
    {
        private JoojleEntities _dbcontext;
        private DbSet<Product> dbset;
        public ProductRepository(JoojleEntities dbcontext) : base(dbcontext)
        {
            this._dbcontext = dbcontext;
            this.dbset = _dbcontext.Set<Product>();
        }
    }
}