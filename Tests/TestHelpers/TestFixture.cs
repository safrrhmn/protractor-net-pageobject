using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace protractor_net_pageobject.Tests.TestHelpers
{
    public class TestFixture:WebDriverFactory
    {
        protected TestFixture(BrowserType webDriver) : base(webDriver)
        {
        }
    }
}
