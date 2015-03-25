using Protractor;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;

namespace protractor_net_pageobject.Tests.TestHelpers
{
    /// <summary>
    /// A static factory object for creating WebDriver instances with/without proxies.
    /// </summary>
    public class WebDriverFactory
    {
        public IWebDriver Driver;
        public NgWebDriver NgDriver;

        protected WebDriverFactory(BrowserType type, Proxy proxy)
        {
            Driver = WebDriver(type, proxy);
            NgDriver = new NgWebDriver(Driver);
        }

        protected WebDriverFactory(BrowserType type)
        {
            Driver = WebDriver(type);
            NgDriver = new NgWebDriver(Driver);
        }

        [TestFixtureTearDown]
        public void TestFixtureTearnDown()
        {
            Driver.Quit();
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

        public static IWebDriver WebDriver(BrowserType type, Proxy proxy = null)
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

        /// <summary>
        /// Creates Internet Explorer Driver instance.
        /// </summary>
        /// <param name="proxy">The proxy.</param>
        /// <returns>A new instance of IEDriverServer</returns>
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

        /// <summary>
        /// Creates Firefox Driver instance.
        /// </summary>
        /// <param name="proxy">The proxy.</param>
        /// <returns>A new instance of Firefox Driver</returns>
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


        /// <summary>
        /// Creates Chrome Driver instance.
        /// </summary>
        /// <param name="proxy">The proxy.</param>
        /// <returns>A new instance of Chrome Driver</returns>
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

        /// <summary>
        /// Creates PhantomJs Driver instance..
        /// </summary>
        /// <param name="proxy">The proxy.</param>
        /// <returns>A new instance of PhantomJs</returns>
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
