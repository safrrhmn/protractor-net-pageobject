using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Protractor.PageObjects.Helpers;

namespace Protractor.PageObjects
{
    /// <summary>
    /// This page object exposes all the APIs related to Angular API page.
    /// </summary>
    public class AngularJsApiPage : BaseFactory
    {
        private const string url = "https://docs.angularjs.org/api";

        public AngularJsApiPage(NgWebDriver ngWebDriver)
            : base(ngWebDriver.WrappedDriver, url)
        {

        }

        public AngularDirectivePage ClickAngularDirective()
        {
            //This line is needed in order the NgDriver to know that this is going to be an Angular page
            //Going forward we will re-factor this.
            NgWebDriver ngDriver = new NgWebDriver(NgDriver.WrappedDriver, "[ng-app='docsApp']");

            IList<NgWebElement> eList = NgDriver.FindElements(NgBy.Repeater("navItem in navGroup.navItems"));
            foreach (NgWebElement ngWebElement in eList.Where(ngWebElement => ngWebElement.FindElement(By.XPath("//a[.='directive']")).Displayed))
            {
                ngWebElement.Click();
                break;
            }

            return new AngularDirectivePage(ngDriver);
        }
    }
}
