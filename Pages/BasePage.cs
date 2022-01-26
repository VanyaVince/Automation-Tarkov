using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarkov.Driver;

namespace Tarkov.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver => WebDriverFactory.Driver; 
    }
}
