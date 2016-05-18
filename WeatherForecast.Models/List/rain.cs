using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherForecast.Models.List
{
    /// <summary>
    /// Rain Models
    /// </summary>
    public class rain
    {
        [JsonProperty(PropertyName = "3h")]
        public double ThreeHours { get; set; }
    }
}
