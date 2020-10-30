using System;
using Xunit;
using SimpleOne.Controllers;

namespace SimpleOne.test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]//Basically a test 

        public void GetReturnsMyName(){
            Console.WriteLine($"\n\n\nQUalquer vcaddddlor vapsdjfejc\n\n");
            int i = 1;
            var returnValue = controller.Get(i);
            Assert.Equal("Casa ", returnValue.Value);

        }

        
    }
}
