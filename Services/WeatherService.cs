using System;
using System.Collections.Generic;
using Weather.Models;

namespace Weather.Services
{
    /// <summary>
    /// Service to provide weather forecasts.
    /// </summary>
    public class WeatherService : IWeatherService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Warm", "Hot", "Scorching"
        };

        /// <inheritdoc/>
        public IEnumerable<WeatherForecast> GetForecasts()
        {
            var rng = new Random();
            for (int i = 0; i < 5; i++)
            {
                yield return new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(i),
                    TemperatureC = rng.Next(-20, 35),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                };
            }
        }
    }
}