using System;

namespace Weather.Models
{
    /// <summary>
    /// Represents a weather forecast entry.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>The date of the forecast.</summary>
        public DateTime Date { get; set; }

        /// <summary>The temperature in Celsius.</summary>
        public int TemperatureC { get; set; }

        /// <summary>The temperature in Fahrenheit.</summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>Summary of the weather conditions.</summary>
        public string Summary { get; set; }
    }
}
