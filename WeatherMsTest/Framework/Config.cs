using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

namespace WeatherMsTest.Framework
{
    /*
 * This class is to read configuration urls,apikey, cityame & threshold range
 * This is also used to read object repository which is xml & si stored in \bin\Debug\netcoreapp3.1
 */
    public class Config
    {
        private static IWebDriver driver = ChromeBrowser.getInstance().getDriver();
        public static String readCity()
        {
            return returnValue(ConfigVariable.city);
        }

        public static String readApi()
        {
            return returnValue(ConfigVariable.ApiKey);
        }

        public static String readOpenWeatherUrl()
        {
            return returnValue(ConfigVariable.OpenweathermapUrl);
        }

        public static String readNDTYWeatherUrl()
        {
            return returnValue(ConfigVariable.NDTYWeatherUrl);
        }

        private static String returnValue(String key)
        {
            return JObject.Parse(File.ReadAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName+"/Config.json")).GetValue(key).ToString();
        }
        public static String readComparatorThreshold()
        {
            return returnValue(ConfigVariable.ComparatorThreshold);
        }
        public static bool calculateThreshold(double apiop, double ndtvop)
        {
            if ((Math.Abs(Math.Abs(apiop) - Math.Abs(ndtvop))) > double.Parse(Config.readComparatorThreshold())) return false;
            else return true;
        }

    }
}
