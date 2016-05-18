using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherForecast.Models;
using WeatherForecast.Services;
using WeatherForecast.Services.Interface;

namespace WeatherForecast.Web.Controllers
{
    public class HomeController : Controller
    {
        private IWeatherServicesRepository weatherServicesRepository;       

        public HomeController(IWeatherServicesRepository weatherServicesRepository)
        {
            this.weatherServicesRepository = weatherServicesRepository;
        }

        public ActionResult Index(FormCollection formCollection)
        { 
            string selectedItem = "Sydney,au";

            if (formCollection["drpLocation"] != null)
               selectedItem = formCollection["drpLocation"].ToString();

            var list = new SelectList(new[]
                                          {
                                              new {ID="Sydney,au", Name="Sydney, NSW"},
                                              new {ID="Hobart,au", Name="Hobart, TAS"},
                                              
                                          },
                         "ID", "Name", selectedItem);

            var result = weatherServicesRepository.GetNext5DaysWeather(selectedItem);

            ViewBag.StartFrom = Convert.ToDateTime(result.list.OrderBy(cv => cv.dt).First().dt_txt).ToString("dd-MMM-yyyy");
            ViewBag.StartTo = Convert.ToDateTime(result.list.OrderBy(cv => cv.dt).Last().dt_txt).ToString("dd-MMM-yyyy");            
            ViewBag.TotalRainfall = result.list.Sum(cv => cv.rain == null ? 0 : cv.rain.ThreeHours).ToString();
            ViewData["ListLocation"] = list;
            
            return View(result);
        }     
 


    }
}