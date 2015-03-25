using Protractor;
using protractor_net_pageobject.PageObjects.PageObjectHelpers;

namespace protractor_net_pageobject.PageObjects
{
    /// <summary>
    /// Exposes the APIs to interact with Angular Directive Page.
    /// </summary>
    public class AngularDirectivePage : BaseFactory
    {
        public AngularDirectivePage(NgWebDriver ngDriver)
            : base(ngDriver.WrappedDriver)
        {

        }
    }
}
