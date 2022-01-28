using Tarkov.Pages;

namespace Tarkov.Steps
{
    public class StorePageSteps
    {
        private readonly StorePage _storePage;

        public StorePageSteps()
        {
            _storePage = new StorePage();
        }

        public void ProceedToBooksSection()
        {
            _storePage.ClickOnBooksSection();
        }
    }
}
