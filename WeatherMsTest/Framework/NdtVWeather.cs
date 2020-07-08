using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using WeatherMsTest.PageObject;

namespace WeatherMsTest.Framework
{
    public class NdtVWeather : IweatherForcast
    {
        IWebDriver browser = ChromeBrowser.getInstance().getDriver();

        float IweatherForcast.humidityInPercentage()
        {
            throw new NotImplementedException();
        }

        public double temperatureInDegree()
        {
            NdtvWeatherMapview ndtv = new NdtvWeatherMapview(browser);
            ndtv.NavigateToPage();
            ndtv.validatePage();
            ndtv.searchMetrocity(Config.readCity());
            return double.Parse(ndtv.extractTemperatureOfMetrocity());
        }

        float IweatherForcast.windInKM()
        {
            throw new NotImplementedException();
        }
    }
}
