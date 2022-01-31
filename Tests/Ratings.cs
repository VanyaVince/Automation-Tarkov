using NUnit.Framework;
using Tarkov.Constant;
using Tarkov.Data;

namespace Tarkov.Tests
{
    public class Ratings : BaseTest
    {
        private readonly int _expectedRecordsNumberDisplayedPerPage = 100;

        [Test]
        [Retry(2)]
        public void SortByPlaytimeValueWithValidLevelTest()
        {
            HomePageSteps.ProceedTo(HeaderTitles.Ratings);
            RatingsPageSteps.SortRatingsBy(RatingsCategory.Playtime);

            Assert.AreEqual(RatingsPageSteps.CountRecords(), _expectedRecordsNumberDisplayedPerPage);
            Assert.IsTrue(RatingsPageSteps.IsCorrectLevelValuesDisplayed());
        }
    }
}
