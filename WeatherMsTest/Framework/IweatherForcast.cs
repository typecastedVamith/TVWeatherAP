using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherMsTest.Framework
{
    interface IweatherForcast
    {
        public double temperatureInDegree();
        public float humidityInPercentage();
        public float windInKM();
    }
}
