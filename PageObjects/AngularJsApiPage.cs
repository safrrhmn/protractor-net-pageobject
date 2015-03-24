using Protractor;
using protractor_net_pageobject.PageObjects.PageObjectHelpers;

namespace protractor_net_pageobject.PageObjects
{
    public class AngularJsApiPage : BaseFactory
    {
        public AngularJsApiPage(NgWebDriver ngWebDriver)
            : base(ngWebDriver.WrappedDriver)
        {

        }
    }
}
