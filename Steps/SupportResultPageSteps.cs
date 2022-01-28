using Tarkov.Pages;

namespace Tarkov.Steps
{
    public class SupportResultPageSteps
    {
        private SupportResultPage _supportResultPage;

        public SupportResultPageSteps()
        {
            _supportResultPage = new SupportResultPage();
        }

        public string GetPageTitle()
        {
            return _supportResultPage.GetTitleValue();
        }
    }
}
