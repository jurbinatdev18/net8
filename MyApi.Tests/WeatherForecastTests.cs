using MyApi.Models;
using Xunit;

namespace MyApi.Tests;

public class WeatherForecastTests
{
    [Fact]
    public void TemperatureF_IsCalculatedCorrectly()
    {
        // Arrange
        var forecast = new WeatherForecast { TemperatureC = 0 };

        // Act
        var tempF = forecast.TemperatureF;

        // Assert
        Assert.Equal(32, tempF);
    }
}
