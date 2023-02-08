using Assignment.helper.abstractFactory;
using Assignment.util;

namespace UnitTest.helper.abstractFactory;

public class TugboatFactoryUnitTest
{
    [Test]
    public void Test_CreateTugboat()
    {
        ITugboatFactory factory = new TugboatFactory();
        var vessel = factory.CreateTugboat(Constents.VESSEL_TYPE_TUGBOAT_DEFAULT_NAME, Constents.TODAY, 10.2, 20);
        Assert.Multiple(() =>
        {
            StringAssert.Contains(Constents.VESSEL_TYPE_TUGBOAT_DEFAULT_NAME, vessel.Name);
            Assert.That(vessel.VesselSpeed, Is.EqualTo(10.2));
            Assert.That(vessel.VesselType, Is.EqualTo(Constents.VESSEL_TYPE_TUGBOAT));
        });
    }
}