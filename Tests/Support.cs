using NUnit.Framework;
using Tarkov.Constant;
using Tarkov.Data;

namespace Tarkov.Tests
{
    public class Support : BaseTest
    {
        [Test]
        [Retry(2)]
        public void FindInformationAboutCertainErrorTest()
        {
            HomePageSteps.ProceedTo(HeaderTitles.Support);
            SupportPageSteps.FindInformationOf(Error._208);

            Assert.AreEqual(Error._208, SupportResultPageSteps.GetPageTitle());
        }
    }
}
