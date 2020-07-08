using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace WeatherMsTest.Framework
{
    class OpenWeatherMap : IweatherForcast
    {
        public float humidityInPercentage()
        {
            throw new NotImplementedException();
        }

        public double temperatureInDegree()
        {
            return double.Parse(JObject.Parse(requestWeatherForCity())["main"]["temp"].ToString().Trim()) - 273.15;
        }

        public float windInKM()
        {
            throw new NotImplementedException();
        }

        private String requestWeatherForCity()
        {
            var client = new RestClient(Config.readOpenWeatherUrl());
            var request = new RestRequest("?q=" + Config.readCity() + "&appid=" + Config.readApi(), Method.GET);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute(request);
            return response.Content;
        }
    }
}

