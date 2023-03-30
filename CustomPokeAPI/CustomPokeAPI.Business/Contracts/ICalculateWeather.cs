using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPokeAPI.Business.Contracts
{
    public interface ICalculateWeather
    {

        IEnumerable<WeatherForecastDTO> GetWeatherForecast();

    }
}
