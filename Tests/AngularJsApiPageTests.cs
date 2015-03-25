using NUnit.Framework;
using protractor_net_pageobject.PageObjects;
using protractor_net_pageobject.Tests.TestHelpers;

namespace protractor_net_pageobject.Tests
{
    [TestFixture(BrowserType.PhantomJS)]
    public class AngularJsApiPageTests : WebDriverFactory
    {
        public AngularJsApiPageTests(BrowserType driverType)
            : base(driverType)
        {

        }

        /// <summary>
        /// Sample test to demonstrate the use NgWebDriver with angular page.
        /// </summary>
        [Test]
        public void AngularApiPageTest()
        {
            AngularDirectivePage directivePage = new AngularJsApiPage(NgDriver)
                .ClickAngularDirective();
            
            Assert.IsNotNull(directivePage);
        }
    }
}