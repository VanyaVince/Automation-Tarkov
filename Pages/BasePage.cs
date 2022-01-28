using OpenQA.Selenium;
using Tarkov.Driver;
using Tarkov.Extentions;

namespace Tarkov.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver => WebDriverFactory.Driver;
        protected DriverExtention DriverExtention => new DriverExtention();

        public void SwtichToNewlyOpenedTab()
        {
            var windowsCount = Driver.WindowHandles.Count;
            Driver.SwitchTo().Window(Driver.WindowHandles[windowsCount - 1]);
        }

    }
}
