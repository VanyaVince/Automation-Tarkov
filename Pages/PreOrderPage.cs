using OpenQA.Selenium;
using Tarkov.Components;
using Tarkov.Data.Css;
using Tarkov.Driver;
using Tarkov.ElementWrapper;

namespace Tarkov.Pages
{
    public class PreOrderPage : BasePage
    {
        private Header _header = new Header();
        private Element PreOrderButton => new Element(By.XPath("//div[@class='button']"));
        private Element RegistrationWarningWindow => new Element(By.XPath("//div[@id='modal']"));

        public void ClickOnPreOrderButton()
        {
            PreOrderButton.Hover();
            PreOrderButton.Click();
        }

        public void WaitWarningWindowAppears()
        {
            DriverManager.Wait().Until(waiting => IsWarningWindowAppeared());
        }

        public bool IsWarningWindowAppeared()
        {
            return RegistrationWarningWindow.GetCssAttributeValue(Attributes.Display) != CssValue.None;
        }

        public bool IsUserLogged()
        {
            return _header.IsUserLogged();
        }
    }
}
