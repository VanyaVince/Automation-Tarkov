using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
