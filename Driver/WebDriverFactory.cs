using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Concurrent;
using System.Linq;

namespace Tarkov.Driver
{
    public class WebDriverFactory
    {
        private static ConcurrentDictionary<string, IWebDriver> _driverCollection = new ConcurrentDictionary<string, IWebDriver>();

        public static IWebDriver Driver {

            get
            {
                return _driverCollection.First(pair => pair.Key == TestContext.CurrentContext.Test.ClassName).Value;
            }

            set => _driverCollection.TryAdd(TestContext.CurrentContext.Test.ClassName, value); 
        }

        public static void InitializeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            var chromeBrowser = new ChromeDriver(options);
            Driver = chromeBrowser;
        }

        public static void QuitDriver()
        {
            Driver.Quit();
            Driver.Dispose();
            _driverCollection.TryRemove(TestContext.CurrentContext.Test.ClassName, out _);
        }
    }
}
