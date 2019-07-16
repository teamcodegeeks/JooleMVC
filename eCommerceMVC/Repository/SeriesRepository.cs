using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;
using System.Data.Entity;

namespace eCommerceMVC.Repository
{
    public class SeriesRepository:GenericRepository<Series>, ISeriesRepository
    {
        private JoojleEntities _dbcontext;
        private DbSet<ProductSubCategory> dbset;
        public SeriesRepository(JoojleEntities dbcontext) : base(dbcontext)
        {
            this._dbcontext = dbcontext;
            this.dbset = _dbcontext.Set<ProductSubCategory>();
        }
    }
}