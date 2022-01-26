using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
