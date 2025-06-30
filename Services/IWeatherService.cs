using System.Collections.Generic;
using Weather.Models;

namespace Weather.Services
{
    /// <summary>
    /// Interface for weather services.
    /// </summary>
    public interface IWeatherService
    {
        /// <summary>
        /// Gets a list of weather forecasts.
        /// </summary>
        /// <returns>List of forecasts.</returns>
        IEnumerable<WeatherForecast> GetForecasts();
    }
}
