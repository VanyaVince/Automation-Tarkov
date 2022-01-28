using OpenQA.Selenium;
using Tarkov.ElementWrapper;

namespace Tarkov.Pages
{
    public class SupportPage
    {
        private string _predictionLocator = "//ul[@id='knowledge_results']//a[contains(text(),'{0}')]";
        private TextBox SearchField => new TextBox(By.XPath("//input[@id='main_search']"));
        
        public void TypeValue(string value)
        {
            SearchField.SetText(value);
        }

        public void ClickOnPredictionOf(string article)
        {
            new Element(By.XPath(string.Format(_predictionLocator, article))).Click();
        }
    }
}
