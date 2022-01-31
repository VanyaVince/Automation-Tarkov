using NUnit.Framework;
using Tarkov.Constant;
using Tarkov.Data.Wiki;

namespace Tarkov.Tests
{
    public class Weapon : BaseTest
    {
        private readonly string _expectedCartridgeOfAK_47M = "5.45x39mm";

        [Test]
        [Retry(2)]
        public void CheckWeaponCatridgeTest()
        {
            HomePageSteps.ProceedTo(HeaderTitles.Wiki);
            WikiPageSteps.SelectCategoryFromGear(GearCategory.Weapon);

            Assert.AreEqual(_expectedCartridgeOfAK_47M, WikiResultPageSteps.GetCartridgeOfWeapon(Weapons.AK_74M));
        }
    }
}
