using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;

namespace eCommerceMVC.UoW
{
    public partial class UnitofWork:IDisposable
    {
        private JoojleEntities dbcontext;
        private  UserRepository userrepository;
        private  ManufactureRepository manufacturerepository;
        private  ModelRepository modelrepository;
        private  ModelTypeRepository modeltyperepository;
        private  ProductRepository productrepository;
        private  ProductCategoryRepository productcategoryrepository;
        private  ProductSubCategoryRepository productsubcategoryrepository;
        private  ProductTechSpecRepository producttechspecrepository;
        private  SeriesRepository seriesrepository;
        private  SpecFilterRepository specfilterrepository;
        public UnitofWork(JoojleEntities dbcontext) {
            this.dbcontext = dbcontext;
        }
        
        public UserRepository UserRepository
        {
            get {
                if (userrepository == null)
                {
                    userrepository = new UserRepository(dbcontext);
                }
                //if (!userrepository.ifdbcontext())
                //else disposed = false;
                return userrepository;
            }
        }
        
        public ManufactureRepository ManufactureRepository
        {
            get {
                if (manufacturerepository == null) {
                    manufacturerepository = new ManufactureRepository(dbcontext);
                }
                return manufacturerepository;
            }
        }
        public ModelRepository ModelRepository
        {
            get {
                if (modelrepository == null) {
                    modelrepository = new ModelRepository(dbcontext);
                }
                return modelrepository;
            }
        }
        public ModelTypeRepository ModelTypeRepository
        {
            get{
                if (modeltyperepository == null) {
                    modeltyperepository = new ModelTypeRepository(dbcontext);
                }
                return modeltyperepository;
            }
        }
        public ProductRepository ProductRepository
        {
            get {
                if (productrepository == null) {
                    productrepository = new ProductRepository(dbcontext);
                }
                return productrepository;
            }
        }
        public ProductCategoryRepository ProductCategoryRepository
        {
            get {
                if (productcategoryrepository == null) {
                    productcategoryrepository = new ProductCategoryRepository(dbcontext);
                }
                return productcategoryrepository;
            }
        }
        public ProductSubCategoryRepository ProductSubCategoryRepository
        {
            get {
                if (productsubcategoryrepository == null) {
                    productsubcategoryrepository = new ProductSubCategoryRepository(dbcontext);
                }
                return productsubcategoryrepository;
            }
        }
        public ProductTechSpecRepository ProductTechSpecRepository
        {
            get {
                if (producttechspecrepository == null) {
                    producttechspecrepository = new ProductTechSpecRepository(dbcontext);
                }
                return producttechspecrepository;
            }
        }
        public SeriesRepository SeriesRepository
        {
            get {
                if (seriesrepository == null) {
                    seriesrepository = new SeriesRepository(dbcontext);
                }
                return seriesrepository;
            }
        }
        public SpecFilterRepository SpecFilterRepository
        {
            get {
                if (specfilterrepository == null) {
                    specfilterrepository = new SpecFilterRepository(dbcontext);
                }
                return specfilterrepository;
            }
        }
        public void Save() {
            dbcontext.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing) {
            if (!this.disposed)
                if (disposing)
                    dbcontext.Dispose();
            this.disposed = true;
        }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
       
    }
}