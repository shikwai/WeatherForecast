using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WeatherForecast.Models.List
{
    /// <summary>
    /// Snow Models
    /// </summary>
    public class snow
    {
       [JsonProperty(PropertyName = "3h")]
        public double ThreeHours { get; set; }
    }
}
