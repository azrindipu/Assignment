using Assignment.helper.abstractFactory;
using Assignment.util;

namespace UnitTest.helper.abstractFactory;

public class FerryFactoryUnitTest
{
    [Test]
    public void Test_CreateFerry()
    {
        IFerryFactory factory = new FerryFactory();
        var vessel = factory.CreateFerry(Constents.VESSEL_TYPE_FERRY_DEFAULT_NAME, Constents.TODAY, 10.2, 20);
        Assert.Multiple(() =>
        {
            StringAssert.Contains(Constents.VESSEL_TYPE_FERRY_DEFAULT_NAME, vessel.Name);
            Assert.That(vessel.VesselSpeed, Is.EqualTo(10.2));
            Assert.That(vessel.VesselType, Is.EqualTo(Constents.VESSEL_TYPE_FERRY));
        });
    }
}