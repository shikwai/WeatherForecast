using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherForecast.Models.City;

namespace WeatherForecast.Models
{
    /// <summary>
    /// City Models
    /// </summary>
    public class city
    {
        public int id { get; set; }
        public string name { get; set; }        
        public coord coord { get; set; }
        public string country { get; set; }
        public string poplution { get; set; }
        public sys sys { get; set; }
    }
}
