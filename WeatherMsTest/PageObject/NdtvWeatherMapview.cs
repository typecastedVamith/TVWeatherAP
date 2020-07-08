using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using WeatherMsTest.Framework;

namespace WeatherMsTest.PageObject
{
    class NdtvWeatherMapview
    {
        private IWebDriver driver;
        public NdtvWeatherMapview()
        {
            // do nothing
        }
        public NdtvWeatherMapview(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "searchBox")]
        [CacheLookup]
        private IWebElement searchCity;

        [FindsBy(How = How.XPath, Using = "//span[@class='heading']/b[contains(text(),'Degrees')]")]
        [CacheLookup]
        private IWebElement degreeInCelcius;

        public void NavigateToPage()
        {
            driver.Navigate().GoToUrl(Config.readNDTYWeatherUrl());
        }

        public void searchMetrocity(String city)
        {
            searchCity.Click();
            sendText(city);
        }

        public void sendText(String searchString)
        {
            searchCity.SendKeys(searchString);
        }

        public String extractTemperatureOfMetrocity()
        {
            driver.FindElement(By.XPath(XpathBuilder.xpathByTag("div", Config.readCity()))).Click();
            return degreeInCelcius.Text.Replace("Temp in Degrees:", "").Trim();
        }
        
        public void validatePage()
        {
            Assert.AreEqual(driver.Title, "NDTV Weather - Weather in your Indian City");
        }
            
    }
}
