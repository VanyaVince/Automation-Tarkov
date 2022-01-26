using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tarkov.ElementWrapper;

namespace Tarkov.Pages
{
    public class ProductListeningPage
    {
        private UIElement LanguageDropdown => new UIElement(By.XPath("//div[contains(@class,'settings__container')]//a"));
        private string _bookLocator = "//span[contains(text(), '{0}') and contains(text(),'{1}')]";
        private string _languageLocator = "//div[@class = 'toggles__left']//button[text()='{0}']";
        public void ClickOnBook(string title, string bookLanguage)
        {
            //ToDo Enum for book and language
            new UIElement(By.XPath(string.Format(_bookLocator, title, bookLanguage))).Click();
        }

        public void ClickOnLanguageDropdown()
        {
            LanguageDropdown.Click();
        }

        public void SelectLanguage(string language)
        {
            new Button(By.XPath(string.Format(_languageLocator, language))).Click();
        }
    }
}
