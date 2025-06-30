using Microsoft.AspNetCore.Mvc;
using Weather.Services;
using Weather.Models;

namespace Weather.Controllers
{
    /// <summary>
    /// Controller for weather operations.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _service;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherController"/> class.
        /// </summary>
        /// <param name="service">Injected weather service.</param>
        public WeatherController(IWeatherService service)
        {
            _service = service;
        }

        /// <summary>
        /// Gets the weather forecast.
        /// </summary>
        /// <returns>A list of weather forecasts.</returns>
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _service.GetForecasts();
        }
    }
}

