using Protractor.PageObjects.Helpers;

namespace Protractor.PageObjects
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
