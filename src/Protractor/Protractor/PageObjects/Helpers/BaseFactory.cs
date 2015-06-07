using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Protractor.PageObjects.Helpers
{
    /// <summary>
    /// Page Object containing helper methods.
    /// Contains all the generic functionalities.
    /// </summary>
    public class BaseFactory
    {
        private readonly TimeSpan _pageLoadTimeOut = new TimeSpan(10);
        public IWebDriver Driver { get; set; }
        public NgWebDriver NgDriver { get; set; }

        public BaseFactory(IWebDriver driver, string url = "")
        {
            Driver = driver;
            NgDriver = new NgWebDriver(driver);
            if (!String.IsNullOrEmpty(url))
            {
                Driver.Navigate().GoToUrl(url);
            }
            Driver.Manage().Timeouts().SetPageLoadTimeout(_pageLoadTimeOut);
            Driver.Manage().Window.Maximize();
            PageFactory.InitElements(driver, this);
        }
    }
}
