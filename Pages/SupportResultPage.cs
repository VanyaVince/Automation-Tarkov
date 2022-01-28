using OpenQA.Selenium;
using Tarkov.ElementWrapper;

namespace Tarkov.Pages
{
    public class SupportResultPage
    {
        private Element PageTitle => new Element(By.XPath("//h1"));

        public string GetTitleValue()
        {
            return PageTitle.GetText();
        }
    }
}
