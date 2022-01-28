using Tarkov.Data;
using Tarkov.Pages;

namespace Tarkov.Steps
{
    public class ProductListeningPageSteps
    {
        private readonly ProductListeningPage _productListeningPage;

        public ProductListeningPageSteps()
        {
            _productListeningPage = new ProductListeningPage();
        }

        public void SelectBook(string bookTitle, string bookLanguage)
        {
            SwitchLanguageTo(Language.English);
            _productListeningPage.ClickOnBook(bookTitle, bookLanguage);
        }

        public void SwitchLanguageTo(string language)
        {
            _productListeningPage.ClickOnLanguageDropdown();
            _productListeningPage.SelectLanguage(language);
            _productListeningPage.ClickOnLanguageDropdown();
        }
    }
}
