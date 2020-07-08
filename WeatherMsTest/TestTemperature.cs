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
            var TTemperature = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Config.json";
            
            IweatherForcast ndtv = new NdtVWeather();
            IweatherForcast oApi = new OpenWeatherMap();
            Assert.IsTrue((Math.Abs(Math.Abs(ndtv.temperatureInDegree()) - Math.Abs(oApi.temperatureInDegree()))) > double.Parse(Config.readComparatorThreshold()),"Temperatue is more than threshold, ");
        }
    }

}