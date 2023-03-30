using CustomPokeAPI.Business.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CustomPokeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICalculateWeather _calculateWeather;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICalculateWeather calculateWeather)
        {
            _logger = logger;
            _calculateWeather = calculateWeather;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult Get()
        {
           return this.Ok(new {currentWeather = _calculateWeather.GetWeatherForecast() });
        }

        [HttpPut]
        [Route("updateWeather")]
        public ActionResult UpdateWeather() 
        {
            return this.Ok(new { updated = true});
        }


    }
}