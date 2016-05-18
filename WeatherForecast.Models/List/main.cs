using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherForecast.Models.List
{
    /// <summary>
    /// List Main Models
    /// </summary>
    public class main
    {
        public double temp { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public double pressure { get; set; }
        public double sea_level { get; set; }
        public double grnd_level { get; set; }
        public double humidity { get; set; }
        public double temp_kf { get; set; }
    }
}
