using System;
using Xunit;
using SimpleApi.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleApi.Test
{
    public class UnitTest1
    {

    [Fact]
    public void GetReturnsAnyValue()
    {
      var serviceProvider = new ServiceCollection()
          .AddLogging()
          .BuildServiceProvider();

      var factory = serviceProvider.GetService<ILoggerFactory>();

      var logger = factory.CreateLogger<WeatherForecastController>();

      WeatherForecastController controller = new WeatherForecastController(logger);

      var forecasts = controller.Get();
      var count = ((WeatherForecast[])forecasts).Length;
      // check to make sure 5 records come back
      Assert.Equal(5,count);
    }

        [Fact]
        public void Test1()
        {

        }
    }
}
