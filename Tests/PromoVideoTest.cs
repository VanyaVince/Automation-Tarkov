using NUnit.Framework;

namespace Tarkov.Tests
{
    public class PromoVideoTest : BaseTest
    {
        [Test]
        [Retry(2)]
        public void PlayVideoTest()
        {
            HomePageSteps.PlayPromoVideo();

            Assert.IsTrue(HomePageSteps.IsVideoPlaying());
        }
    }
}
