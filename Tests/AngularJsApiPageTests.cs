using NUnit.Framework;
using protractor_net_pageobject.PageObjects;
using protractor_net_pageobject.Tests.TestHelpers;
using Protractor;

namespace protractor_net_pageobject.Tests
{
    [TestFixture(BrowserType.Chrome)]
    public class AngularJsApiPageTests:WebDriverFactory
    {
        public AngularJsApiPageTests(BrowserType ngWebDriver)
            : base(ngWebDriver)
        {

        }

        /// <summary>
        /// Sample test to demonstrate the use NgWebDriver with angular page.
        /// </summary>
        [Test]
        public void HelloNgDriver()
        {
            new AngularJsHomePage(NgWebDriver).ClickApiReferenceLink();


            //NgWebElement ngElement = ngWebDriver.FindElement(NgBy.Input("q"));
            // ngElement.Clear();
            // ngElement.SendKeys("Hello NgWebDriver");
        }

        ///// <summary>
        ///// Sample test to demonstrate the use wrapper driver with angular and non-angular hybrid page.
        ///// </summary>
        //[Test]
        //public void HelloNgWrapperDriver()
        //{
        //    IWebElement element = _ngWebDriver.WrappedDriver.FindElement(By.CssSelector("[ng-change='search(q)']"));
        //    element.Clear();
        //    element.SendKeys("Hello Wrapper Driver");
        //}
    }
}