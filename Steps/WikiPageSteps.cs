using Tarkov.Pages;

namespace Tarkov.Steps
{
    public class WikiPageSteps
    {
        private readonly WikiPage _wikiPage;

        public WikiPageSteps()
        {
            _wikiPage = new WikiPage();
        }

        public void SelectCategoryFromGear(string category)
        {
            _wikiPage.HoverOverGearTab();
            _wikiPage.ClickOnCategory(category);
        }
    }
}
