using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarkov.ElementWrapper;

namespace Tarkov.Pages
{
    public class StorePage
    {
        private UIElement BooksSection => new UIElement(By.XPath("//img[contains(@src, 'cups')]"));

        public void ClickOnBooksSection()
        {
            BooksSection.Click();
        }
    }
}
