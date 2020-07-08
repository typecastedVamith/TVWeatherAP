using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using WeatherMsTest.Framework;

namespace WeatherMsTest
{
    [Binding]
    public class WeatherTestSteps
    {
        double ndtv;
        double oApi;

        [Given(@"I Read weather from NDTV News Website")]
        public void GivenIReadWeatherFromNDTVNewsWebsite()
        {
            IweatherForcast ndtv = new NdtVWeather();
            this.ndtv = ndtv.temperatureInDegree();
        }

        [When(@"I Read Weather from openweather API")]
        public void WhenIReadWeatherFromOpenweatherAPI()
        {
            IweatherForcast oApi = new OpenWeatherMap();
           this.oApi = oApi.temperatureInDegree();

        }

        [Then(@"Weather should be within threshold range")]
        public void ThenWeatherShouldBeWithinThresholdRange()
        {
            Assert.IsTrue((Math.Abs(Math.Abs(ndtv) - Math.Abs(oApi))) > double.Parse(Config.readComparatorThreshold()), "Temperatue is more than threshold, test case failed");
        }

    }
}
