using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarkov.Driver;

namespace Tarkov.ElementWrapper.Elements
{
    public class BaseElementsList
    {
        private readonly By _locator;
        private IReadOnlyCollection<IWebElement> _elements => WebDriverFactory.Driver.FindElements(_locator);

        public BaseElementsList(By locator)
        {
            _locator = locator;
        }

        public bool IsEmpty()
        {
            return _elements.Count == 0;
        }

        public IWebElement GetFirstElement()
        {
            WaitForElementToBeExisted();
            return _elements.First();
        }

        public int CountElements()
        {
            WaitForElementToBeExisted();
            return _elements.Count();
        }

        public List<string> GetText()
        {
            WaitForElementToBeExisted();
            return _elements.Select(el => el.Text).ToList();
        }

        private void WaitForElementToBeExisted()
        {
            DriverManager.Wait().Until(waiting => { return WebDriverFactory.Driver.FindElements(_locator).Count > 0; });
        }
    }
}
