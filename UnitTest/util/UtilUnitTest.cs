using Assignment.util;

namespace UnitTest.util;

public class UtilUnitTest
{
    [Test]
    public void Test_GetRand()
    {
        var util = Util.GetRand(10, 20);
        Assert.That(util, Is.GreaterThanOrEqualTo(10));
        Assert.That(util, Is.LessThanOrEqualTo(20));
    }
}