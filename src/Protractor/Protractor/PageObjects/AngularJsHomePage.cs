using OpenQA.Selenium.Support.PageObjects;
using Protractor.PageObjects.Helpers;

namespace Protractor.PageObjects
{
    public class AngularJsHomePage : BaseFactory
    {
        public AngularJsHomePage(NgWebDriver webDriver)
            : base(webDriver.WrappedDriver)
        {

        }

        #region Elements Mapping

        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Design Docs & Notes')]")]
        private NgWebElement AngularDocAndNotesLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Develop ')]")]
        private NgWebElement Develop { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'docs.angularjs.org/api')]")]
        private NgWebElement ApiReferenceLink { get; set; }

        #endregion

        /// <summary>
        /// Exposes public API to click Design Docs & Notes link
        /// </summary>
        /// <returns>Angular Google Driver public Page Object</returns>
        public AngularGoogleDriverPage NavigateToDocsAndNotes()
        {
            AngularDocAndNotesLink.Click();
            return new AngularGoogleDriverPage(NgDriver);
        }
    }
}
