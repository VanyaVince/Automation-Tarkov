using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Linq;
using Tarkov.Driver;

namespace Tarkov.ElementWrapper
{
    public class BaseElement
    {
        protected By _locator;
        //private IWebElement _element;

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
        private void WaitElementIsClickable()
        {
            DriverManager.Wait().Until(waiting => { return Element.Enabled; });
        }

        private void WaitForElementToBeVisible()
        {
            WaitForElementToBeExisted();
            DriverManager.Wait().Until(waiting => { return Element.Displayed; });
        }

        private void WaitForElementToBeExisted()
        {
            DriverManager.Wait().Until(waiting => { return Driver.FindElements(_locator).Count > 0; });
        }
    }
}
