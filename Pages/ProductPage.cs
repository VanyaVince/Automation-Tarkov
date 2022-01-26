using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarkov.ElementWrapper;

namespace Tarkov.Pages
{
    public class ProductPage
    {
        private UIElement ProductPrice => new UIElement(By.XPath("//div[contains(@class,'options-container') and not(contains(@class,'mobile'))]//span"));

        public string GetProductPrice()
        {
            return ProductPrice.GetText();
        }
    }
}
