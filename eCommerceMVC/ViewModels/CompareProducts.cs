using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerceMVC.ViewModels
{
    public class CompareProducts
    {
        public int ManufactureId { get; set; }
        public string MaunfactureIdName { get; set; }
        public int ModelTypeId { get; set; }
        public string UseType { get; set; }
        public string Application { get; set; }
        public string Accessories { get; set; }
        public string MountingLocation { get; set; }
        public short ModelYear { get; set; }
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int SeriesId { get; set; }
        public string SeriesName { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string ImageURL { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public short? AirFlow { get; set; }
        public decimal? PowerMin { get; set; }
        public decimal? PowerMax { get; set; }
        public short? OperatingVoltageMin { get; set; }
        public short? OperatingVoltageMax { get; set; }
        public short? FanSpeedMin { get; set; }
        public short? FanSpeedMax { get; set; }
        public byte? NumOfFanSpeed { get; set; }
        public byte? SoundAtMaxSpeed { get; set; }
        public decimal? FanSweepDiameter { get; set; }
        public decimal? HeightMin { get; set; }
        public decimal? HeightMax { get; set; }
        public decimal? Weight { get; set; }
        public byte? LevelOfSuction { get; set; }
        public decimal? Height { get; set; }
        public short? MaxRuntime { get; set; }
        public byte? LevelOfTemperature { get; set; }
        public decimal? Length { get; set; }
    }
}