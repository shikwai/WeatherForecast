using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherForecast.Services;
using WeatherForecast.Services.Interface;
using WeatherForecast.Web.Controllers;

namespace WeatherForecast.Web
{
    public static class AutofacConfig
    {
        public static void RegisterComponents()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<WeatherServicesRepository>().As<IWeatherServicesRepository>();
            builder.RegisterType<HomeController>();            
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

    }
}