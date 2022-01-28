using NUnit.Framework;

namespace Tarkov.Tests
{
    public class PromoVideoTest : BaseTest
    {
        [Test]
        public void PlayVideoTest()
        {
            HomePageSteps.PlayPromoVideo();

            Assert.IsTrue(HomePageSteps.IsVideoPlaying());
        }
    }
}
