using Protractor;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using protractor_net_pageobject.PageObjects.PageObjectHelpers;

namespace protractor_net_pageobject.PageObjects
{
    public class AngularJsHomePage : BaseFactory
    {
        public AngularJsHomePage(NgWebDriver webDriver)
            : base(webDriver.WrappedDriver)
        {
           
        }

        #region Elements Mapping

        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Design Docs & Notes')]")]
        private IWebElement AngularDocAndNotesLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Develop ')]")]
        private IWebElement Develop { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'docs.angularjs.org/api')]")]
        private IWebElement ApiReferenceLink { get; set; }

        #endregion

        /// <summary>
        /// Exposes public API to click Design Docs & Notes link
        /// </summary>
        /// <returns>Angular Google Driver public Page Object</returns>
        public AngularGoogleDriverPage ClickDocsAndNotes()
        {
            AngularDocAndNotesLink.Click();
            return new AngularGoogleDriverPage(NgDriver);
        }

        /// <summary>
        /// Clicks the API reference link under Develop on top menu.
        /// </summary>
        /// <returns>AngularJs API reference Page</returns>
        public AngularJsApiPage ClickApiReferenceLink()
        {
            Develop.Click();
            Driver.FindElement(By.XPath("//a[contains(@href,'docs.angularjs.org/api')]")).Click();
            return new AngularJsApiPage(NgDriver);
        }
    }
}
