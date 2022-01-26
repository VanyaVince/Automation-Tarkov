using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using Tarkov.Components;
using Tarkov.ElementWrapper;

namespace Tarkov.Pages
{
    public class HomePage : BasePage
    {
        private readonly Header _header = new Header();
        private Button YouTubePlayButton => new Button(By.XPath("//button[@aria-label='Play']"));
        private Button YouTubeContainerButton => new Button(By.XPath("//section[@id='banner_39_youtube']"));
        private UIElement YouTubeIframeDocument => new UIElement(By.XPath("//iframe[@id='VideoPlayer_39']"));
        private UIElement YouTubeProgressBar => new UIElement(By.XPath("//div[@class='ytp-progress-bar']"));
        private UIElement YouTubeScrubberIndicator => new UIElement(By.XPath("//div[@class='ytp-scrubber-container']"));

        public void ClickOnYoutubeSection()
        {
            YouTubeContainerButton.Hover();
            YouTubeContainerButton.Click();
        }

        public void ClickOnYouTubePlayButton()
        {
            YouTubePlayButton.Click();
        }

        public void ClickOnMerchShowMenuItem()
        {
            _header.ClickOnMerchItem();
        }

        public void SwitchToIframe()
        {
            Driver.SwitchTo().Frame(YouTubeIframeDocument.GetElement());
        }

        public void SwtichToNewlyOpenedTab()
        {
            Driver.SwitchTo().Window(Driver.WindowHandles[Driver.WindowHandles.Count -1]);
        }

        public string GetVideoTimeValue()
        {
            YouTubeScrubberIndicator.Hover();
            return YouTubeProgressBar.GetElementAttribute("aria-valuenow");
        }
    }
}
