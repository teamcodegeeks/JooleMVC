using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;
using eCommerceMVC.UoW;
using eCommerceMVC.ViewModels;

namespace eCommerceMVC.Service
{
    public class CompareService
    {
        public IEnumerable<CompareProducts> Summary()

        {
            var unitofwork = new UnitofWork(new JoojleEntities());
            var seriestable = unitofwork.SeriesRepository.GetAll();
            var manufacturetable = unitofwork.ManufactureRepository.GetAll();
            var series_manufacture = from t1 in seriestable
                                     join t2 in manufacturetable on t1.ManufactureId equals t2.ManufactureId
                                     select new CompareProducts
                                     {
                                         //CategoryId = 0,
                                         //CategoryName = "",
                                         ////
                                         //SubCategoryId = t1.SubCategoryId,
                                         ////
                                         //SubCategoryName = "",
                                         ////
                                         //ManufactureId = t1.ManufactureId,
                                         //MaunfactureIdName = t2.ManufactureIdName,
                                         //SeriesId = t1.SeriesId,
                                         //SeriesName = t1.SeriesName,

                                         //////////
                                         ManufactureId = t1.ManufactureId,
                                         MaunfactureIdName = t2.ManufactureIdName,
                                         ModelTypeId = 0,
                                         UseType = "",
                                         Application = "",
                                         Accessories = "",
                                         MountingLocation = "",
                                         ModelYear = 0,
                                         ModelId = 0,
                                         ModelName = "",
                                         SeriesId = t1.SeriesId,
                                         SeriesName = t1.SeriesName,
                                         ProductId = 0,
                                         ProductName = "",
                                         SubCategoryId = t1.SubCategoryId,
                                         SubCategoryName = "",
                                         ImageURL = "",
                                         CategoryId = 0,
                                         CategoryName = "",
                                         AirFlow = 0,
                                         PowerMin = 0,
                                         PowerMax = 0,
                                         OperatingVoltageMin = 0,
                                         OperatingVoltageMax = 0,
                                         FanSpeedMin = 0,
                                         FanSpeedMax = 0,
                                         NumOfFanSpeed = 0,
                                         SoundAtMaxSpeed = 0,
                                         FanSweepDiameter = 0,
                                         HeightMin = 0,
                                         HeightMax = 0,
                                         Weight = 0,
                                         LevelOfSuction = 0,
                                         Height = 0,
                                         MaxRuntime = 0,
                                         LevelOfTemperature = 0,
                                         Length = 0
                                     };

            var temp1 = series_manufacture.ToList();
            var modeltable = unitofwork.ModelRepository.GetAll();
            var modeltypetable = unitofwork.ModelTypeRepository.GetAll();
            var model_modeltype = from t1 in modeltable
                                  join t2 in modeltypetable on t1.ModelId equals t2.ModelId
                                  select new CompareProducts
                                  {
                                      // ModelId = t1.ModelId,
                                      // ModelName = t1.ModelName,
                                      // ModelYear = t2.ModelYear,
                                      // ModelTypeId = t2.ModelTypeId,
                                      // MountingLocation = t2.MountingLocation,
                                      // UseType = t2.UseType,
                                      // Application = t2.Application,
                                      // Accessories = t2.Accessories,
                                      //ManufactureId = t1.ManufactureId,
                                      //SubCategoryId = t1.SubCategoryId
                                      ManufactureId = t1.ManufactureId,
                                      MaunfactureIdName = "",
                                      ModelTypeId = t2.ModelTypeId,
                                      UseType = t2.UseType,
                                      Application = t2.Application,
                                      Accessories = t2.Accessories,
                                      MountingLocation = t2.MountingLocation,
                                      ModelYear = t2.ModelYear,
                                      ModelId = t1.ModelId,
                                      ModelName = t1.ModelName,
                                      SeriesId = t1.SeriesId,
                                      SeriesName = "",
                                      ProductId = 0,
                                      ProductName = "",
                                      SubCategoryId = t1.SubCategoryId,
                                      SubCategoryName = "",
                                      ImageURL = "",
                                      CategoryId = 0,
                                      CategoryName = "",
                                      AirFlow = 0,
                                      PowerMin = 0,
                                      PowerMax = 0,
                                      OperatingVoltageMin = 0,
                                      OperatingVoltageMax = 0,
                                      FanSpeedMin = 0,
                                      FanSpeedMax = 0,
                                      NumOfFanSpeed = 0,
                                      SoundAtMaxSpeed = 0,
                                      FanSweepDiameter = 0,
                                      HeightMin = 0,
                                      HeightMax = 0,
                                      Weight = 0,
                                      LevelOfSuction = 0,
                                      Height = 0,
                                      MaxRuntime = 0,
                                      LevelOfTemperature = 0,
                                      Length = 0,
                                  };
            var temp2 = model_modeltype.ToList();
            var category = unitofwork.ProductCategoryRepository.GetAll();
            var subcategory = unitofwork.ProductSubCategoryRepository.GetAll();
            var category_subcategory = from t1 in category
                                       join t2 in subcategory on t1.CategoryId equals t2.CategoryId
                                       select new CompareProducts
                                       {
                                           //CategoryId = t1.CategoryId,
                                           //CategoryName = t1.CategoryName,
                                           //SubCategoryId = t2.SubCategoryId,
                                           //SubCategoryName = t2.SubCategoryName,
                                           ////
                                           //ManufactureId = 0,
                                           //MaunfactureIdName = "",
                                           //SeriesId = 0,
                                           //SeriesName = ""
                                           ManufactureId = 0,
                                           MaunfactureIdName = "",
                                           ModelTypeId = 0,
                                           UseType = "",
                                           Application = "",
                                           Accessories = "",
                                           MountingLocation = "",
                                           ModelYear = 0,
                                           ModelId = 0,
                                           ModelName = "",
                                           SeriesId = 0,
                                           SeriesName = "",
                                           ProductId = 0,
                                           ProductName = "",
                                           SubCategoryId = t2.SubCategoryId,
                                           SubCategoryName = t2.SubCategoryName,
                                           ImageURL = "",
                                           CategoryId = t1.CategoryId,
                                           CategoryName = t1.CategoryName,
                                           AirFlow = 0,
                                           PowerMin = 0,
                                           PowerMax = 0,
                                           OperatingVoltageMin = 0,
                                           OperatingVoltageMax = 0,
                                           FanSpeedMin = 0,
                                           FanSpeedMax = 0,
                                           NumOfFanSpeed = 0,
                                           SoundAtMaxSpeed = 0,
                                           FanSweepDiameter = 0,
                                           HeightMin = 0,
                                           HeightMax = 0,
                                           Weight = 0,
                                           LevelOfSuction = 0,
                                           Height = 0,
                                           MaxRuntime = 0,
                                           LevelOfTemperature = 0,
                                           Length = 0,
                                       };
            var temp3 = category_subcategory.ToList();
            var product = unitofwork.ProductRepository.GetAll();
            var productspec = unitofwork.ProductTechSpecRepository.GetAll();
            var product_spec = from t1 in product
                               join t2 in productspec on t1.ProductId equals t2.ProductId
                               select new CompareProducts
                               {
                                   //ProductId = t1.ProductId,
                                   //ProductName = t1.ProductName,
                                   //ModelId = t1.ModelId,
                                   //ImageURL = t1.ImageURL,
                                   //SubCategoryId = t1.SubCategoryId,
                                   //AirFlow = t2.AirFlow,
                                   //FanSpeedMax = t2.FanSpeedMax,
                                   //FanSpeedMin = t2.FanSpeedMin,
                                   //FanSweepDiameter = t2.FanSweepDiameter,
                                   //Height = t2.Height,
                                   //HeightMax = t2.HeightMax,
                                   //HeightMin = t2.HeightMin,
                                   //Length = t2.Length,
                                   //LevelOfSuction = t2.LevelOfSuction,
                                   //LevelOfTemperature = t2.LevelOfTemperature,
                                   //MaxRuntime = t2.MaxRuntime,
                                   //NumOfFanSpeed = t2.NumOfFanSpeed,
                                   //OperatingVoltageMax = t2.OperatingVoltageMax,
                                   //OperatingVoltageMin = t2.OperatingVoltageMin,
                                   //PowerMax = t2.PowerMax,
                                   //PowerMin = t2.PowerMin,
                                   //SoundAtMaxSpeed = t2.SoundAtMaxSpeed,
                                   //Weight = t2.Weight
                                   ManufactureId = 0,
                                   MaunfactureIdName = "",
                                   ModelTypeId = 0,
                                   UseType = "",
                                   Application = "",
                                   Accessories = "",
                                   MountingLocation = "",
                                   ModelYear = 0,
                                   ModelId = t1.ModelId,
                                   ModelName = "",
                                   SeriesId = 0,
                                   SeriesName = "",
                                   ProductId = t1.ProductId,
                                   ProductName = t1.ProductName,
                                   SubCategoryId = t1.SubCategoryId,
                                   SubCategoryName = "",
                                   ImageURL = t1.ImageURL,
                                   CategoryId = 0,
                                   CategoryName = "",
                                   AirFlow = t2.AirFlow,
                                   PowerMin = t2.PowerMin,
                                   PowerMax = t2.PowerMax,
                                   OperatingVoltageMin = t2.OperatingVoltageMin,
                                   OperatingVoltageMax = t2.OperatingVoltageMax,
                                   FanSpeedMin = t2.FanSpeedMin,
                                   FanSpeedMax = t2.FanSpeedMax,
                                   NumOfFanSpeed = t2.NumOfFanSpeed,
                                   SoundAtMaxSpeed = t2.SoundAtMaxSpeed,
                                   FanSweepDiameter = t2.FanSweepDiameter,
                                   HeightMin = t2.HeightMin,
                                   HeightMax = t2.HeightMax,
                                   Weight = t2.Weight,
                                   LevelOfSuction = t2.LevelOfSuction,
                                   Height = t2.Height,
                                   MaxRuntime = t2.MaxRuntime,
                                   LevelOfTemperature = t2.LevelOfTemperature,
                                   Length = t2.Length,
                               };
            var temp4 = product_spec.ToList();
            //var product_model = from t1 in product_spec
            //                    join t2 in model_modeltype on t1.ModelId equals t2.ModelId
            //                    select new ProductSummary
            //                    {
            //                        ProductId = t1.ProductId,
            //                        ProductName = t1.ProductName,
            //                        ModelId = t1.ModelId,
            //                        ImageURL = t1.ImageURL,
            //                        SubCategoryId = t1.SubCategoryId,
            //                        AirFlow = (t1.AirFlow),
            //                        FanSpeedMax = (t1.FanSpeedMax),
            //                        FanSpeedMin = (t1.FanSpeedMin),
            //                        FanSweepDiameter = t1.FanSweepDiameter),
            //                        Height = t1.Height),
            //                        HeightMax = t1.HeightMax),
            //                        HeightMin = t1.HeightMin),
            //                        Length = t1.Length),
            //                        LevelOfSuction = t1.LevelOfSuction),
            //                        LevelOfTemperature = t1.LevelOfTemperature),
            //                        MaxRuntime = (t1.MaxRuntime),
            //                        NumOfFanSpeed = t1.NumOfFanSpeed),
            //                        OperatingVoltageMax = (t1.OperatingVoltageMax),
            //                        OperatingVoltageMin = (t1.OperatingVoltageMin),
            //                        PowerMax = t1.PowerMax),
            //                        PowerMin = t1.PowerMin),
            //                        SoundAtMaxSpeed = t1.SoundAtMaxSpeed),
            //                        Weight = t1.Weight),
            //                        ManufactureId = t2.ManufactureId,
            //                        ModelName = t2.ModelName,
            //                        ModelTypeId = t2.ModelTypeId,
            //                        ModelYear = t2.ModelYear,
            //                        MountingLocation = t2.MountingLocation,
            //                        UseType = t2.UseType
            //                       };
            var category_series = from t1 in category_subcategory
                                  join t2 in series_manufacture on t1.SubCategoryId equals t2.SubCategoryId
                                  select new CompareProducts
                                  {

                                      //CategoryId = t1.CategoryId,
                                      //CategoryName = t1.CategoryName,
                                      //SubCategoryId = t2.SubCategoryId,
                                      //SubCategoryName = t1.SubCategoryName,
                                      //ManufactureId = t2.ManufactureId,
                                      //MaunfactureIdName = t2.MaunfactureIdName,
                                      //SeriesId = t2.SeriesId,
                                      //SeriesName = t2.SeriesName
                                      ManufactureId = t2.ManufactureId,
                                      MaunfactureIdName = t2.MaunfactureIdName,
                                      ModelTypeId = 0,
                                      UseType = "",
                                      Application = "",
                                      Accessories = "",
                                      MountingLocation = "",
                                      ModelYear = 0,
                                      ModelId = 0,
                                      ModelName = "",
                                      SeriesId = t2.SeriesId,
                                      SeriesName = t2.SeriesName,
                                      ProductId = 0,
                                      ProductName = "",
                                      SubCategoryId = t1.SubCategoryId,
                                      SubCategoryName = t1.SubCategoryName,
                                      ImageURL = "",
                                      CategoryId = t1.CategoryId,
                                      CategoryName = t1.CategoryName,
                                      AirFlow = 0,
                                      PowerMin = 0,
                                      PowerMax = 0,
                                      OperatingVoltageMin = 0,
                                      OperatingVoltageMax = 0,
                                      FanSpeedMin = 0,
                                      FanSpeedMax = 0,
                                      NumOfFanSpeed = 0,
                                      SoundAtMaxSpeed = 0,
                                      FanSweepDiameter = 0,
                                      HeightMin = 0,
                                      HeightMax = 0,
                                      Weight = 0,
                                      LevelOfSuction = 0,
                                      Height = 0,
                                      MaxRuntime = 0,
                                      LevelOfTemperature = 0,
                                      Length = 0,
                                  };
            var temp5 = category_series.ToList();
            var category_series_model = from t1 in category_series
                                        join t2 in model_modeltype on t1.SeriesId equals t2.SeriesId
                                        select new CompareProducts
                                        {
                                            //SeriesId = t1.SeriesId,
                                            //SeriesName = t1.SeriesName,
                                            //ManufactureId = t1.ManufactureId,
                                            //MaunfactureIdName = t1.MaunfactureIdName,
                                            //SubCategoryId = t1.SubCategoryId,
                                            //SubCategoryName = t1.SubCategoryName,
                                            //CategoryName = t1.CategoryName,
                                            //CategoryId = t1.CategoryId,
                                            //ModelId = t2.ModelId,
                                            //ModelName = t1.ModelName,
                                            //ModelYear = t2.ModelYear,
                                            //ModelTypeId = t2.ModelTypeId,
                                            //MountingLocation = t2.MountingLocation,
                                            //UseType = t2.UseType,
                                            ManufactureId = t1.ManufactureId,
                                            MaunfactureIdName = t1.MaunfactureIdName,
                                            ModelTypeId = t2.ModelTypeId,
                                            UseType = t2.UseType,
                                            Application = t2.Application,
                                            Accessories = t2.Accessories,
                                            MountingLocation = t2.MountingLocation,
                                            ModelYear = t2.ModelYear,
                                            ModelId = t2.ModelId,
                                            ModelName = t2.ModelName,
                                            SeriesId = t1.SeriesId,
                                            SeriesName = t1.SeriesName,
                                            ProductId = 0,
                                            ProductName = "",
                                            SubCategoryId = t1.SubCategoryId,
                                            SubCategoryName = t1.SubCategoryName,
                                            ImageURL = "",
                                            CategoryId = t1.CategoryId,
                                            CategoryName = t1.CategoryName,
                                            AirFlow = 0,
                                            PowerMin = 0,
                                            PowerMax = 0,
                                            OperatingVoltageMin = 0,
                                            OperatingVoltageMax = 0,
                                            FanSpeedMin = 0,
                                            FanSpeedMax = 0,
                                            NumOfFanSpeed = 0,
                                            SoundAtMaxSpeed = 0,
                                            FanSweepDiameter = 0,
                                            HeightMin = 0,
                                            HeightMax = 0,
                                            Weight = 0,
                                            LevelOfSuction = 0,
                                            Height = 0,
                                            MaxRuntime = 0,
                                            LevelOfTemperature = 0,
                                            Length = 0,

                                        };
            var temp6 = category_series_model.ToList();
            var productinfo = from t1 in product_spec
                              join t2 in category_series_model on t1.ModelId equals t2.ModelId
                              select new CompareProducts
                              {
                                  ManufactureId = t2.ManufactureId,
                                  MaunfactureIdName = t2.MaunfactureIdName,
                                  ModelTypeId = t2.ModelTypeId,
                                  UseType = t2.UseType,
                                  Application = t2.Application,
                                  Accessories = t2.Accessories,
                                  MountingLocation = t2.MountingLocation,
                                  ModelYear = t2.ModelYear,
                                  ModelId = t2.ModelId,
                                  ModelName = t2.ModelName,
                                  SeriesId = t2.SeriesId,
                                  SeriesName = t2.SeriesName,
                                  ProductId = t1.ProductId,
                                  ProductName = t1.ProductName,
                                  SubCategoryId = t1.SubCategoryId,
                                  SubCategoryName = t2.SubCategoryName,
                                  ImageURL = t1.ImageURL,
                                  CategoryId = t2.CategoryId,
                                  CategoryName = t2.CategoryName,
                                  AirFlow = t1.AirFlow,
                                  PowerMin = t1.PowerMin,
                                  PowerMax = t1.PowerMax,
                                  OperatingVoltageMin = t1.OperatingVoltageMin,
                                  OperatingVoltageMax = t1.OperatingVoltageMax,
                                  FanSpeedMin = t1.FanSpeedMin,
                                  FanSpeedMax = t1.FanSpeedMax,
                                  NumOfFanSpeed = t1.NumOfFanSpeed,
                                  SoundAtMaxSpeed = t1.SoundAtMaxSpeed,
                                  FanSweepDiameter = t1.FanSweepDiameter,
                                  HeightMin = t1.HeightMin,
                                  HeightMax = t1.HeightMax,
                                  Weight = t1.Weight,
                                  LevelOfSuction = t1.LevelOfSuction,
                                  Height = t1.Height,
                                  MaxRuntime = t1.MaxRuntime,
                                  LevelOfTemperature = t1.LevelOfTemperature,
                                  Length = t1.Length,
                              };
            var temptest = productinfo.ToList();
            return productinfo.ToList();
        }

    }
}