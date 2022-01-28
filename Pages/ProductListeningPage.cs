using OpenQA.Selenium;
using Tarkov.ElementWrapper;

namespace Tarkov.Pages
{
    public class ProductListeningPage
    {
        private string _bookLocator = "//span[contains(text(), '{0}') and contains(text(),'{1}')]";
        private string _languageLocator = "//div[@class = 'toggles__left']//button[text()='{0}']";
        private Element LanguageDropdown => new Element(By.XPath("//div[contains(@class,'settings__container')]//a"));
        
        public void ClickOnBook(string title, string bookLanguage)
        {
            new Element(By.XPath(string.Format(_bookLocator, title, bookLanguage))).Click();
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
