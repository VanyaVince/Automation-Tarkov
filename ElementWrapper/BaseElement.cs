using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Linq;
using Tarkov.Driver;

namespace Tarkov.ElementWrapper
{
    public class BaseElement
    {
        protected By _locator;
        protected IWebDriver Driver => WebDriverFactory.Driver;
        protected IWebElement Element => Driver.FindElements(_locator).FirstOrDefault();

        public BaseElement(By locator)
        {
            _locator = locator;
        }

        public void Click()
        {
            WaitForElementToBeExisted();
            WaitForElementToBeVisible();
            WaitElementIsClickable();

            Element.Click();
        }

       public void Hover()
        {
            WaitForElementToBeExisted();
            new Actions(Driver).MoveToElement(Element).Perform();
        }

        public IWebElement GetElement()
        {
            WaitForElementToBeExisted();
            return Element;
        }

        public string GetElementAttribute(string value)
        {
            WaitForElementToBeExisted();
            return Element.GetAttribute(value);
        }

        public string GetText()
        {
            WaitForElementToBeExisted();
            return Element.Text;
        }

        public string GetCssAttributeValue(string value)
        {
            WaitForElementToBeExisted();
            return Element.GetCssValue(value);
        }

        public bool IsDisplayed()
        {
            WaitForElementToBeVisible();
            return true;
        }

        protected void WaitElementIsClickable()
        {
            DriverManager.Wait().Until(waiting => { return Element != null && Element.Enabled; });
        }

        protected void WaitForElementToBeVisible()
        {
            WaitForElementToBeExisted();
            DriverManager.Wait().Until(waiting => { return Element != null && Element.Displayed; });
        }

        protected void WaitForElementToBeExisted()
        {
            DriverManager.Wait().Until(waiting => { return Driver.FindElements(_locator).Count > 0; });
        }
    }
}
