﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;

namespace eCommerceMVC.Repository
{
    public class SpecFilterRepository:GenericRepository<SpecFilter>, ISpecFilterRepository 
    {
        private JoojleEntities _dbcontext;
        private DbSet<SpecFilter> dbset;
        public SpecFilterRepository(JoojleEntities dbcontext) : base(dbcontext)
        {
            this._dbcontext = dbcontext;
            this.dbset = _dbcontext.Set<SpecFilter>();
        }
    }
}