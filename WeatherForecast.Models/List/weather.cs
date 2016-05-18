using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherForecast.Models.List
{
    /// <summary>
    /// List WeatherModels
    /// </summary>
    public class weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public int icon { get; set; }
    }
}
