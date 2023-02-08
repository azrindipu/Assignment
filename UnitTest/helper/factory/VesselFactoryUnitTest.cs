using Assignment.helper.abstractFactory;
using Assignment.helper.factory;
using Assignment.util;

namespace UnitTest.helper.factory;

public class VesselFactoryUnitTest
{
    [Test]
    public void Test_CreateVessel_Ferry()
    {
        IFerryFactory factory = new FerryFactory();
        IVesselFactory vesselFactory = new VesselFactory();
        var vessel = vesselFactory.CreateVessel(factory);
        Assert.Multiple(() =>
        {
            StringAssert.Contains(Constents.VESSEL_TYPE_FERRY_DEFAULT_NAME, vessel.Name);
            Assert.That(vessel.VesselSpeed, Is.GreaterThanOrEqualTo(1));
            Assert.That(vessel.VesselSpeed, Is.LessThanOrEqualTo(200));
            Assert.That(vessel.VesselType, Is.EqualTo(Constents.VESSEL_TYPE_FERRY));
        });
    }

    [Test]
    public void Test_CreateVessel_Tugboat()
    {
        ITugboatFactory factory = new TugboatFactory();
        IVesselFactory vesselFactory = new VesselFactory();
        var vessel = vesselFactory.CreateVessel(factory);
        Assert.Multiple(() =>
        {
            StringAssert.Contains(Constents.VESSEL_TYPE_TUGBOAT_DEFAULT_NAME, vessel.Name);
            Assert.That(vessel.VesselSpeed, Is.GreaterThanOrEqualTo(1));
            Assert.That(vessel.VesselSpeed, Is.LessThanOrEqualTo(200));
            Assert.That(vessel.VesselType, Is.EqualTo(Constents.VESSEL_TYPE_TUGBOAT));
        });
    }

    [Test]
    public void Test_CreateVessel_Submarine()
    {
        ISubmarineFactory factory = new SubmarineFactory();
        IVesselFactory vesselFactory = new VesselFactory();
        var vessel = vesselFactory.CreateVessel(factory);
        Assert.Multiple(() =>
        {
            StringAssert.Contains(Constents.VESSEL_TYPE_SUBMARINE_DEFAULT_NAME, vessel.Name);
            Assert.That(vessel.VesselSpeed, Is.GreaterThanOrEqualTo(1));
            Assert.That(vessel.VesselSpeed, Is.LessThanOrEqualTo(200));
            Assert.That(vessel.VesselType, Is.EqualTo(Constents.VESSEL_TYPE_SUBMARINE));
        });
    }
}