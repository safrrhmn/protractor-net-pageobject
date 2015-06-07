using Protractor.PageObjects.Helpers;

namespace Protractor.PageObjects
{

    /// <summary>
    /// This page object exposes all the APIs related to AngularJs Google Driver.
    /// </summary>
    public class AngularGoogleDriverPage : BaseFactory
    {
        public AngularGoogleDriverPage(NgWebDriver ngWebDriver)
            : base(ngWebDriver.WrappedDriver)
        {

        }
    }
}
