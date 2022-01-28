using NUnit.Framework;

namespace Tarkov.Tests
{
    public class Order : BaseTest
    {
        [Test]
        public void WairningWindowForPreOrderAppearTest()
        {
            HomePageSteps.ProceedToPreOderPage();
            PreOrderPageSteps.MakePreOrder();

            Assert.IsTrue(PreOrderPageSteps.IsRegistrationWarningWindowAppeared());
        }
    }
}
