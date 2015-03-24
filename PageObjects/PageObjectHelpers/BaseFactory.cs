using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;

namespace protractor_net_pageobject.PageObjects.PageObjectHelpers
{
    /// <summary>
    /// Page Object helper methods.
    /// Contains all the generic functionalities.
    /// </summary>
    public class BaseFactory
    {
        private const string Url = "https://angularjs.org/";
        private readonly TimeSpan _pageLoadTimeOut = new TimeSpan(10);

        public IWebDriver Driver { get; set; }
        public NgWebDriver NgDriver { get; set; }

        public BaseFactory(IWebDriver driver)
        {
            Driver = driver;
            Driver.Navigate().GoToUrl(Url);
            Driver.Manage().Timeouts().SetPageLoadTimeout(_pageLoadTimeOut);
            Driver.Manage().Window.Maximize();
            PageFactory.InitElements(Driver,this);
        }
    }
}
