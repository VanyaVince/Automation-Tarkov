using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tarkov.Tests
{
    public class Books : BaseTest
    {
        private readonly string _bookTitle = "Master of the night";
        private readonly string _language = "Russian";
        private readonly int _expectedBookPrice = 260;

        [Test]
        public void VerifyPriceOfNightMasterBook()
        {
            HomePageSteps.ProceedToMerchPage();
            StorePageSteps.ProceedToBooksSection();
            ProductListeningPageSteps.SelectBook(_bookTitle, _language);

            Assert.IsTrue(ProductPageSteps.IsProductPriceEqualTo(_expectedBookPrice));

        }
    }
}
