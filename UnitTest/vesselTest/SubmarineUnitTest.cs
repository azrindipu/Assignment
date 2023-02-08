using Assignment.util;
using Assignment.vessels;

namespace UnitTest.vesselTest;

public class SubmarineUnitTest
{
    [Test]
    public void Test_MaxDepth()
    {
        var submarine = new Submarine(Constents.VESSEL_TYPE_SUBMARINE_DEFAULT_NAME, Constents.TODAY)
        {
            MaxDepth = 10.7
        };
        Assert.That(submarine.MaxDepth, Is.EqualTo(10.7));
    }

    [Test]
    public void Test_Constructor_Name_YearBuilt()
    {
        var submarine = new Submarine(Constents.VESSEL_TYPE_SUBMARINE_DEFAULT_NAME, Constents.TODAY);
        Assert.Multiple(() =>
        {
            Assert.That(submarine.MaxDepth, Is.EqualTo(0));
            Assert.That(submarine.VesselSpeed, Is.EqualTo(0));
        });
    }

    [Test]
    public void Test_Constructor_Name_YearBuilt_Speed_MaxDepth()
    {
        var submarine = new Submarine(Constents.VESSEL_TYPE_SUBMARINE_DEFAULT_NAME, Constents.TODAY, 10.2, 10.7);
        Assert.Multiple(() =>
        {
            Assert.That(submarine.MaxDepth, Is.EqualTo(10.7));
            Assert.That(submarine.VesselSpeed, Is.EqualTo(10.2));
        });
    }

    [Test]
    public void Test_Constructor_Name_YearBuilt_Speed()
    {
        var submarine = new Submarine(Constents.VESSEL_TYPE_SUBMARINE_DEFAULT_NAME, Constents.TODAY, 10.2);
        Assert.Multiple(() =>
        {
            Assert.That(submarine.MaxDepth, Is.EqualTo(0));
            Assert.That(submarine.VesselSpeed, Is.EqualTo(10.2));
        });
    }

    [Test]
    public void Test_Constructor_Name__MaxDepth_YearBuilt()
    {
        var submarine = new Submarine(Constents.VESSEL_TYPE_SUBMARINE_DEFAULT_NAME, 10.3, Constents.TODAY);
        Assert.Multiple(() =>
        {
            Assert.That(submarine.MaxDepth, Is.EqualTo(10.3));
            Assert.That(submarine.VesselSpeed, Is.EqualTo(0));
        });
    }

    [Test]
    public void Test_ToString()
    {
        DateTime dateTime = new DateTime(2019, 05, 09, 9, 15, 0);
        var submarine = new Submarine(Constents.VESSEL_TYPE_SUBMARINE_DEFAULT_NAME, dateTime, 10.3, 10.6);
        var result = submarine.ToString();
        StringAssert.Contains(
            "Info:  vesselType: Submarine, name: DEFAULT_SUBMARINE_NAME, yearBuilt: 5/9/2019 9:15:00 AM,  Speed: 10.3, maxDepth: 10.6",
            result);
    }

    [Test]
    public void Test_GetVesselInfo()
    {
        DateTime dateTime = new DateTime(2019, 05, 09, 9, 15, 0);
        var submarine = new Submarine(Constents.VESSEL_TYPE_SUBMARINE_DEFAULT_NAME, dateTime, 10.3, 10.6);
        submarine.GetVesselInfo();
        var result = submarine.ToString();
        StringAssert.Contains(
            "Info:  vesselType: Submarine, name: DEFAULT_SUBMARINE_NAME, yearBuilt: 5/9/2019 9:15:00 AM,  Speed: 10.3, maxDepth: 10.6",
            result);
    }
}