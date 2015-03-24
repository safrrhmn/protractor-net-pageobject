using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using Protractor;

namespace protractor_net_pageobject.Tests.TestHelpers
{
    /// <summary>
    /// A static factory class for creating WebDriver instances with proxies.
    /// </summary>
    public class WebDriverFactory
    {
        public NgWebDriver NgWebDriver;

        protected WebDriverFactory(BrowserType type, Proxy proxy)
        {
            var webDriver = CreateWebDriverWithProxy(type,proxy );
            NgWebDriver = new NgWebDriver(webDriver);
        }

        protected WebDriverFactory(BrowserType type)
        {
            var webDriver = CreateWebDriverWithProxy(type);
            NgWebDriver = new NgWebDriver(webDriver);
        }

        [TestFixtureTearDown]
        public void TestFixtureTearnDown()
        {
            NgWebDriver.Quit();
        }

        /// <summary>
        /// Types of browser available for proxy examples.
        /// </summary>
        public enum BrowserType
        {
            IE,
            Chrome,
            Firefox,
            PhantomJS
        }

        public static IWebDriver CreateWebDriverWithProxy(BrowserType type, Proxy proxy = null)
        {
            IWebDriver driver = null;

            switch (type)
            {
                case BrowserType.IE:
                    driver = IeDriver(proxy);
                    break;
                case BrowserType.Firefox:
                    driver = FirefoxDriver(proxy);
                    break;
                case BrowserType.Chrome:
                    driver = ChromeDriver(proxy);
                    break;
                default:
                    driver = PhanthomJsDriver(proxy);
                    break;
            }
            
            return driver;
        }

        private static IWebDriver IeDriver(Proxy proxy)
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            if (proxy != null)
            {
                options.Proxy = proxy;
                options.UsePerProcessProxy = true;
            }
            options.EnsureCleanSession = true;
            IWebDriver driver = new InternetExplorerDriver(options);
            return driver;
        }

        private static IWebDriver FirefoxDriver(Proxy proxy)
        {
            FirefoxProfile profile = new FirefoxProfile();
            if (proxy != null)
            {
                profile.SetProxyPreferences(proxy);
            }
            IWebDriver driver = new FirefoxDriver(profile);
            return driver;
        }
        
        private static IWebDriver ChromeDriver(Proxy proxy)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            if (proxy != null)
            {
                chromeOptions.Proxy = proxy;
            }
            IWebDriver driver = new ChromeDriver(chromeOptions);
            return driver;
        }
        
        private static IWebDriver PhanthomJsDriver(Proxy proxy)
        {
            PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();
            if (proxy != null)
            {
                service.ProxyType = "http";
                service.Proxy = proxy.HttpProxy;   
            }
            IWebDriver driver = new PhantomJSDriver(service);
            return driver;
        }
    }
}
