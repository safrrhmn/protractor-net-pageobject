using protractor_net_pageobject.PageObjects.PageObjectHelpers;
using Protractor;

namespace protractor_net_pageobject.PageObjects
{
    public class AngularGoogleDriverPage:BaseFactory
    {
        public AngularGoogleDriverPage(NgWebDriver ngWebDriver) 
            : base(ngWebDriver.WrappedDriver)
        {

        }
    }
}
