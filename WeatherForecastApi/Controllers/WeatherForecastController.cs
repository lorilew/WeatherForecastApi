using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var forecasts = WeatherForecastStore.Get();
            return forecasts.ToArray();
        }
    }
}