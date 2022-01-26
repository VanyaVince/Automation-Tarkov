using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tarkov.Pages;

namespace Tarkov.Steps
{
    public class HomePageSteps
    {
        private readonly HomePage _homePage;
        public HomePageSteps()
        {
            _homePage = new HomePage();
        }

        public void PlayPromoVideo()
        {
            _homePage.ClickOnYoutubeSection();
            _homePage.SwitchToIframe();
            _homePage.ClickOnYouTubePlayButton();
        }

        public void ProceedToMerchPage()
        {
            _homePage.ClickOnMerchShowMenuItem();
            _homePage.SwtichToNewlyOpenedTab();
        }

        public bool IsVideoPlaying()
        {
            var previousTimeValue = _homePage.GetVideoTimeValue();
            Thread.Sleep(3000);
            var currentTimeValue = _homePage.GetVideoTimeValue();

            return currentTimeValue != previousTimeValue;
        }
    }
}
