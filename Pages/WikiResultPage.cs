using OpenQA.Selenium;
using Tarkov.ElementWrapper;

namespace Tarkov.Pages
{
    public class WikiResultPage
    {
        private string _carttridge = "//table[contains(@class,'wikitable')]//a[@title='{0}']//ancestor::tr//a[contains(@title,'mm')]";

        public string GetCarttridge(string weaponName)
        {
            return new Element(By.XPath(string.Format(_carttridge, weaponName))).GetElementAttribute("title");
        }
    }
}
