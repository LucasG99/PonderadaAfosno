using Xunit;
using System;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System.Linq;

namespace WeatherApp.Tests
{
    public class WeatherTests
    {
        [Fact]
        public void TemperatureF_CalculatesCorrectly()
        {
            // Arrange
            var weatherForecast = new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                TemperatureC = 20,
                Summary = "Mild"
            };

            // Act
            int temperatureF = weatherForecast.TemperatureF;

            // Assert
            Assert.Equal(68, temperatureF);
        }

        [Fact]
        public void WeatherForecast_PropertiesSetCorrectly()
        {
            // Arrange
            var date = DateOnly.FromDateTime(DateTime.Now);
            var tempC = 25;
            var summary = "Hot";

            // Act
            var forecast = new WeatherForecast
            {
                Date = date,
                TemperatureC = tempC,
                Summary = summary
            };

            // Assert
            Assert.Equal(date, forecast.Date);
            Assert.Equal(tempC, forecast.TemperatureC);
            Assert.Equal(summary, forecast.Summary);
        }

        private class WeatherForecast
        {
            public DateOnly Date { get; set; }
            public int TemperatureC { get; set; }
            public string? Summary { get; set; }
            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }
    }
} 