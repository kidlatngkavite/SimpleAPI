using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController Isko = new WeatherForecastController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = Isko.Get(1);
            Assert.Equal("Ferdinand Escolars",returnValue.Value);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
