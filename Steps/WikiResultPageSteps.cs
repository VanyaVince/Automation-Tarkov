using Tarkov.Pages;

namespace Tarkov.Steps
{
    public class WikiResultPageSteps
    {
        private readonly WikiResultPage _wikiResultPage;

        public WikiResultPageSteps()
        {
            _wikiResultPage = new WikiResultPage();
        }

        public string GetCartridgeOfWeapon(string weaponName)
        {
            return _wikiResultPage.GetCarttridge(weaponName);
        }
    }
}
