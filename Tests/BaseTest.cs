using NUnit.Framework;
using OpenQA.Selenium;
using Tarkov.Driver;
using Tarkov.Pages;
using Tarkov.Steps;

namespace Tarkov
{  
    [Parallelizable(ParallelScope.Self)]
    public class BaseTest
    {
        protected IWebDriver Driver => WebDriverFactory.Driver;

        protected HomePageSteps HomePageSteps = new HomePageSteps();
        protected StorePageSteps StorePageSteps = new StorePageSteps();
        protected ProductListeningPageSteps ProductListeningPageSteps = new ProductListeningPageSteps();
        protected ProductPageSteps ProductPageSteps = new ProductPageSteps();

        [SetUp]
        protected void Setup()
        {
            WebDriverFactory.InitializeDriver();

            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.escapefromtarkov.com/");
        }

        [TearDown]
        protected void TearDown()
        {
            WebDriverFactory.QuitDriver();
        }
    }
}