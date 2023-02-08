using Assignment.util;
using Assignment.vessels;

namespace UnitTest.vesselTest;

public class TugboatUnitTest
{
    [Test]
    public void Test_MaxForce()
    {
        var tugboat = new Tugboat(Constents.VESSEL_TYPE_TUGBOAT_DEFAULT_NAME, Constents.TODAY)
        {
            MaxForce = 1.4
        };
        Assert.Multiple(() =>
        {
            Assert.That(tugboat.MaxForce, Is.EqualTo(1.4));
            Assert.That(tugboat.VesselSpeed, Is.EqualTo(0));
        });
    }

    [Test]
    public void Test_Constructor_Name_YearBuilt()
    {
        var tugboat = new Tugboat(Constents.VESSEL_TYPE_TUGBOAT_DEFAULT_NAME, Constents.TODAY);
        Assert.Multiple(() =>
        {
            Assert.That(tugboat.MaxForce, Is.EqualTo(0));
            Assert.That(tugboat.VesselSpeed, Is.EqualTo(0));
        });
    }

    [Test]
    public void Test_Constructor_Name_YearBuilt_Speed_MaxForce()
    {
        var tugboat = new Tugboat(Constents.VESSEL_TYPE_TUGBOAT_DEFAULT_NAME, Constents.TODAY, 10.2, 10.4);
        Assert.Multiple(() =>
        {
            Assert.That(tugboat.MaxForce, Is.EqualTo(10.4));
            Assert.That(tugboat.VesselSpeed, Is.EqualTo(10.2));
        });
    }

    [Test]
    public void Test_Constructor_Name_YearBuilt_Speed()
    {
        var tugboat = new Tugboat(Constents.VESSEL_TYPE_TUGBOAT_DEFAULT_NAME, Constents.TODAY, 10.2);
        Assert.Multiple(() =>
        {
            Assert.That(tugboat.MaxForce, Is.EqualTo(0));
            Assert.That(tugboat.VesselSpeed, Is.EqualTo(10.2));
        });
    }

    [Test]
    public void Test_Constructor_Name_MaxForce_YearBuilt()
    {
        var tugboat = new Tugboat(Constents.VESSEL_TYPE_TUGBOAT_DEFAULT_NAME, 3.9, Constents.TODAY);
        Assert.Multiple(() =>
        {
            Assert.That(tugboat.MaxForce, Is.EqualTo(3.9));
            Assert.That(tugboat.VesselSpeed, Is.EqualTo(0));
        });
    }

    [Test]
    public void Test_ToString()
    {
        var dateTime = new DateTime(2019, 05, 09, 9, 15, 0);
        var tugboat = new Tugboat(Constents.VESSEL_TYPE_TUGBOAT_DEFAULT_NAME, dateTime);
        var result = tugboat.ToString();
        Assert.Multiple(() =>
        {
            Assert.That(tugboat.MaxForce, Is.EqualTo(0));
            Assert.That(tugboat.VesselSpeed, Is.EqualTo(0));
            StringAssert.Contains(
                "Info:  vesselType: Tugboat, name: DEFAULT_TUGBOAT_NAME, yearBuilt: 5/9/2019 9:15:00 AM,  Speed: 0, maxForce: 0",
                result);
        });
    }

    [Test]
    public void Test_GetVesselInfo()
    {
        var dateTime = new DateTime(2019, 05, 09, 9, 15, 0);
        var tugboat = new Tugboat(Constents.VESSEL_TYPE_TUGBOAT_DEFAULT_NAME, dateTime);
        var result = tugboat.ToString();
        tugboat.GetVesselInfo();
        Assert.Multiple(() =>
        {
            Assert.That(tugboat.MaxForce, Is.EqualTo(0));
            Assert.That(tugboat.VesselSpeed, Is.EqualTo(0));
            StringAssert.Contains(
                "Info:  vesselType: Tugboat, name: DEFAULT_TUGBOAT_NAME, yearBuilt: 5/9/2019 9:15:00 AM,  Speed: 0, maxForce: 0",
                result);
        });
    }
}