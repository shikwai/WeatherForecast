using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherForecast.Models.List;

namespace WeatherForecast.Models
{
    /// <summary>
    /// List Models
    /// </summary>
    public class list
    {
        public int dt { get; set; }
        public main main { get; set; }
        public weather waether { get; set; }
        public clouds clouds { get; set; }
        public wind wind { get; set; }
        public rain rain { get; set; }
        public snow snow { get; set; }
        public sys sys { get; set; }
        public DateTime dt_txt { get; set; }
    }
}
