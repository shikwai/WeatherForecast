using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json;
using WeatherForecast.Models;
using WeatherForecast.Services.Interface;

namespace WeatherForecast.Services
{
    /// <summary>
    /// WeatherServicesRepository classs
    /// GetNext5DaysWeathers
    /// </summary>
    public class WeatherServicesRepository : IWeatherServicesRepository
    {
        readonly string baseUri = ConfigurationManager.AppSettings["WeatherAPI"];
        readonly string ApiId = ConfigurationManager.AppSettings["WeatherAPIKey"];

        public WeatherServicesRepository()
        {
        }

        public Weather GetNext5DaysWeather(string location)
        {
            string uri = baseUri + "forecast?q=" + location + "&mode=json&appid=" + ApiId;

            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObjectAsync<Weather>(response.Result).Result;
            }
        }
    }
}
