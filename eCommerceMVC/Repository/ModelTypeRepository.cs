using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;

namespace eCommerceMVC.Repository
{
    public class ModelTypeRepository:GenericRepository<ModelType>,IModelTypeRepository
    {
        private JoojleEntities _dbcontext;
        private DbSet<ModelType> dbset;
        public ModelTypeRepository(JoojleEntities dbcontext) : base(dbcontext)
        {
            this._dbcontext = dbcontext;
            this.dbset = _dbcontext.Set<ModelType>();
        }
    }
}