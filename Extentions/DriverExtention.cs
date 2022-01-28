using OpenQA.Selenium;
using Tarkov.Driver;

namespace Tarkov.Extentions
{
    public class DriverExtention
    {
        private IWebDriver Driver => WebDriverFactory.Driver;

        public void SwitchToIframe(IWebElement iframe)
        {
            Driver.SwitchTo().Frame(iframe);
        }
    }
}
