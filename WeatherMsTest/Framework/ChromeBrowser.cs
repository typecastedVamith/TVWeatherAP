using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WeatherMsTest.Framework
{
    /*
  *  This class is used to inititialze chromeDriver 
  */
    public sealed class ChromeBrowser
    {
        static ChromeBrowser init = new ChromeBrowser();
        private IWebDriver driver;
        ChromeBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        public static ChromeBrowser getInstance()
        {
            return init;
        }
        public IWebDriver getDriver()
        {
            return driver;
        }
    }
}
