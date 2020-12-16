using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSRS.Api.Account.Helpers;

namespace OSRS.Api.UnitTests.Account
{
    [TestClass]
    public class HiscoresUnitTests
    {
        [TestMethod]
        public void ShouldMapDataToAccount()
        {
            var fakeResponse = @"198141,1904,97780615 579235,80,2080883 582152,80,1988722 809344,82,2469141 810157,83,2673446 938876,78,1723230 160247,82,2514955 836048,78,1735675 104557,99,13092843 260186,82,2568987 75218,99,13056130 420772,77,1503283 432981,79,1876214 4567,99,15203569 392327,72,900334 123556,85,3365378 61226,91,6145933 68794,86,3786556 395182,70,763198 868160,63,369791 236756,84,3235621 17327,99,13062217 159741,81,2367353 312274,75,1297156 -1,-1 -1,-1 -1,-1 382938,49 77728,14 88544,31 954873,1 627757,2 -1,-1 217606,1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1 -1,-1";

            var account = new ResponseStringToAccountMapper().Map(fakeResponse);

            // test just a few skills, more could be added.
            Assert.AreEqual(account.Total.Level, 1904);
            Assert.AreEqual(account.Attack.Level, 80);
            Assert.AreEqual(account.Defense.Level, 80);
        }
    }
}
