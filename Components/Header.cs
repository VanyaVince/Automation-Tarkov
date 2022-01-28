using OpenQA.Selenium;
using Tarkov.ElementWrapper;

namespace Tarkov.Components
{
    public class Header
    {
        private string _showMenuLocator = "//ul[contains(@class,'menu')]//a[contains(@href,'{0}')]";
        private Element LoginButton => new Element(By.XPath("//a[@href='/login']"));
        
        public void ClickOnShowMenuOf(string item)
        {
            new Element(By.XPath(string.Format(_showMenuLocator, item.ToLower()))).Click();
        }

        public bool IsUserLogged()
        {
            return LoginButton.IsDisplayed();
        }
    }
}
