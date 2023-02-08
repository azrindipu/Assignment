using Assignment.fleet;
using Assignment.helper;

namespace UnitTest.fleet;

public class FleetUnitTest
{
    [Test]
    public void Test_CountEachTypeOfVessel()
    {
        var simulationHelper = new SimulationHelper();
        var vessels = simulationHelper.CreateVariousTypesOfVessel(100);
        IFleet fleet = new Fleet(vessels);
        fleet.CountEachTypeOfVessel();
        Assert.Pass();
    }

    [Test]
    public void Test_PrintInfoAllVessel()
    {
        var simulationHelper = new SimulationHelper();
        var vessels = simulationHelper.CreateVariousTypesOfVessel(100);
        IFleet fleet = new Fleet(vessels);
        fleet.PrintInfoAllVessel();
        Assert.Pass();
    }

    [Test]
    public void Test_PrintMaxSpeedOfEachTypeOfVessel()
    {
        var simulationHelper = new SimulationHelper();
        var vessels = simulationHelper.CreateVariousTypesOfVessel(100);
        IFleet fleet = new Fleet(vessels);
        fleet.PrintMaxSpeedOfEachTypeOfVessel();
        Assert.Pass();
    }

    [Test]
    public void Test_TotalVessels()
    {
        var simulationHelper = new SimulationHelper();
        var vessels = simulationHelper.CreateVariousTypesOfVessel(100);
        IFleet fleet = new Fleet(vessels);
        fleet.TotalVessels();
        Assert.Pass();
    }
}