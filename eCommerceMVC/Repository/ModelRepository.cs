using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;

namespace eCommerceMVC.Repository
{
    public class ModelRepository:GenericRepository<Model>,IModelRepository
    {
        private JoojleEntities _dbcontext;
        private DbSet<Model> dbset;
        public ModelRepository(JoojleEntities dbcontext) : base(dbcontext)
        {
            this._dbcontext = dbcontext;
            this.dbset = _dbcontext.Set<Model>();
        }
    }
}