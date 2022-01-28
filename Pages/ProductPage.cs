using OpenQA.Selenium;
using Tarkov.ElementWrapper;

namespace Tarkov.Pages
{
    public class ProductPage
    {
        private Element ProductPrice => new Element(By.XPath("//div[contains(@class,'options-container') and not(contains(@class,'mobile'))]//span"));

        public string GetProductPrice()
        {
            return ProductPrice.GetText();
        }
    }
}
