using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            SwitchLanguageTo("English");
            _productListeningPage.ClickOnBook(bookTitle, bookLanguage);
        }

        private void SwitchLanguageTo(string language)
        {
            _productListeningPage.ClickOnLanguageDropdown();
            _productListeningPage.SelectLanguage(language);
            _productListeningPage.ClickOnLanguageDropdown();
        }
    }
}
