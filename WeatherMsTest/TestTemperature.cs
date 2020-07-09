using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherMsTest.Framework;

namespace WeatherMsTest
{

    [TestClass]
    public class TestTemperature
    {
        [TestMethod]
        public void TestTemperaturemtd()
        {           
            IweatherForcast ndtv = new NdtVWeather();
            IweatherForcast oApi = new OpenWeatherMap();
            Assert.IsFalse((Math.Abs(Math.Abs(ndtv.temperatureInDegree()) - Math.Abs(oApi.temperatureInDegree()))) > double.Parse(Config.readComparatorThreshold()),"Temperatue is more than threshold");
        }
    }

}