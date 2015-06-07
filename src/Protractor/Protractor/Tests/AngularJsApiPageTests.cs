 // ReSharper disable once RedundantUsingDirective
using NUnit.Framework;
using Protractor.PageObjects;

namespace Protractor.Tests
{
    [TestFixture(BrowserType.PhantomJS)]
    public class AngularJsApiPageTests : WebDriverFactory
    {
        public AngularJsApiPageTests(BrowserType type) 
            : base(type)
        {

        }

        [TestFixtureSetUp]
        public void SetUp()
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