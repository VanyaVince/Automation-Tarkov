using Tarkov.Pages;

namespace Tarkov.Steps
{
    public class SupportPageSteps
    {
        private SupportPage _supportPage;

        public SupportPageSteps()
        {
            _supportPage = new SupportPage();
        }

        public void FindInformationOf(string value)
        {
            _supportPage.TypeValue(value);
            _supportPage.ClickOnPredictionOf(value);
        }
    }
}
