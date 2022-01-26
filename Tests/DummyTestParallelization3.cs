using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tarkov.Tests
{
    public class DummyTestParallelization3 : BaseTest
    {
        [Test]
        public void OpenGooglePageTest()
        {
            HomePageSteps.PlayPromoVideo();

            Assert.IsTrue(HomePageSteps.IsVideoPlaying());
        }
    }
}
