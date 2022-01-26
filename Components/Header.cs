using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarkov.ElementWrapper;

namespace Tarkov.Components
{
    public class Header
    {
        private UIElement MerchShowMenuItem => new UIElement(By.XPath("//a[contains(@href,'merch')]"));
        
        public void ClickOnMerchItem()
        {
            MerchShowMenuItem.Click();
        }
    }
}
