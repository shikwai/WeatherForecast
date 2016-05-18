using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherForecast.Models
{
    /// <summary>
    /// Weather Models
    /// </summary>
    public class Weather
    {
        public int cod { get; set; }
        public string message { get; set; }
        public city city { get; set; }
        public int cnt { get; set; }
        public List<list> list { get; set; }
    }
}
