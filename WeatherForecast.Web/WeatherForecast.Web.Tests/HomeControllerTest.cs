using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherForecast.Web.Controllers;
using WeatherForecast.Models;
using WeatherForecast.Services.Interface;
using WeatherForecast.Services;

namespace WeatherForecast.Web.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        private IWeatherServicesRepository weatherServicesRepository;
       
        [TestInitialize]
        public void Initialize()
        {
            weatherServicesRepository = new WeatherServicesRepository();
        } 

        [TestMethod]
        public void TestIndexView()
        {
            FormCollection collection = new FormCollection();
            collection.Add("", "");

            var controller = new HomeController(weatherServicesRepository);
            var result = controller.Index(collection) as ViewResult;
            Assert.AreNotEqual(null, result.Model);

        }

        [TestMethod]
        public void TestIndexViewWithLocation()
        {
            FormCollection collection = new FormCollection();
            collection.Add("drpLocation", "Hobart,au");

            var controller = new HomeController(weatherServicesRepository);
            var result = controller.Index(collection) as ViewResult;
            Weather weather = (Weather)result.Model;

            Assert.AreEqual("Hobart", weather.city.name);

        }
    }
}
