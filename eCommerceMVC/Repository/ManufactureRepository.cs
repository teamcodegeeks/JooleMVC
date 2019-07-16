using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;

namespace eCommerceMVC.Repository
{
    public class ManufactureRepository:GenericRepository<Manufacture>,IManufactureRepository
    {
        private JoojleEntities _dbcontext;
        private DbSet<Manufacture> dbset;
        public ManufactureRepository(JoojleEntities dbcontext) : base(dbcontext)
        {
            this._dbcontext = dbcontext;
            this.dbset = _dbcontext.Set<Manufacture>();
        }
    }
}