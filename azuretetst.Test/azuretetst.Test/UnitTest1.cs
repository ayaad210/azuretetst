using azuretetst.Controllers;

namespace azuretetst.Test
{
    public class UnitTest1
    {

        [Fact]
        public void GetName()
        {
            WeatherForecastController weatherForecastController = new WeatherForecastController();

            var val = weatherForecastController.Get();
            Assert.Equal(5,val.Count());
        }

        [Fact]
        public void Test1()
        {

        }
    }
}