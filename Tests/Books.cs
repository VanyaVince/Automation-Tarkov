using NUnit.Framework;
using Tarkov.Constant;
using Tarkov.Data.Book;

namespace Tarkov.Tests
{
    public class Books : BaseTest
    {
        private readonly int _expectedBookPrice = 260;

        [Test]
        public void VerifyPriceOfNightMasterBook()
        {
            HomePageSteps.ProceedTo(HeaderTitles.Merch);
            StorePageSteps.ProceedToBooksSection();
            ProductListeningPageSteps.SelectBook(BookTitle.MasterOfTheNight, BookLanguage.Russian);

            Assert.IsTrue(ProductPageSteps.IsProductPriceEqualTo(_expectedBookPrice));

        }
    }
}
