using System.Threading;
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

        public void ProceedTo(string section)
        {
            _homePage.ClickOnShowMenuOf(section);
            _homePage.SwtichToNewlyOpenedTab();
        }

        public void ProceedToPreOderPage()
        {
            _homePage.ClickOnPreOrderImage();
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
