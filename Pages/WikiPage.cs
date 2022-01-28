using OpenQA.Selenium;
using Tarkov.ElementWrapper;

namespace Tarkov.Pages
{
    public class WikiPage
    {
        private string _categoryLocator = "//div[@class='main-container']//div[contains(@class,'wds-dropdown__content')]//a[contains(@href,'{0}')]";
        private Element GearTab => new Element(By.XPath("//div[@class='main-container']//a[contains(@href,'Weapons')]//ancestor::li[@class='wds-dropdown ']"));

        public void HoverOverGearTab()
        {
            GearTab.Hover();
        }

        public void ClickOnCategory(string category)
        {
            new Element(By.XPath(string.Format(_categoryLocator, category))).Click();
        }
    }
}
