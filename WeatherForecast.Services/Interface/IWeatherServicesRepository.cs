using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Models;

namespace WeatherForecast.Services.Interface
{
    /// <summary>
    /// WeatherServicesRepository interface
    /// </summary>
    public interface IWeatherServicesRepository
    {        
        Weather GetNext5DaysWeather(string location);
    }    
}
