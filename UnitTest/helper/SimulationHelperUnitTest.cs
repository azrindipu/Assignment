using Assignment.helper;

namespace UnitTest.helper;

public class SimulationHelperUnitTest
{
    [Test]
    public void Test_CreateVariousTypesOfVessel()
    {
        var simulationHelper = new SimulationHelper();
        var vessels = simulationHelper.CreateVariousTypesOfVessel(100);
        Assert.Multiple(() =>
        {
            Assert.That(vessels[0].VesselSpeed, Is.GreaterThanOrEqualTo(1));
            Assert.That(vessels[0].VesselSpeed, Is.LessThanOrEqualTo(200));
            Assert.That(vessels.Count, Is.GreaterThanOrEqualTo(1));
            Assert.That(vessels.Count, Is.LessThanOrEqualTo(100));
        });
    }
}