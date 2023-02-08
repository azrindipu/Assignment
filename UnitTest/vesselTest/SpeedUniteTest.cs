using Assignment.util;

namespace UnitTest.vesselTest;

public class SpeedUniteTest
{
    [Test]
    public void Test_No_Arg_Constructor()
    {
        var speed = new Speed();
        Assert.That(speed.VesselSpeed, Is.EqualTo(0));
    }

    [Test]
    public void Test_Arg_Constructor()
    {
        var speed = new Speed(10);
        Assert.That(speed.VesselSpeed, Is.EqualTo(10));
    }

    [Test]
    public void Test_VesselSpeed()
    {
        var speed = new Speed
        {
            VesselSpeed = 10
        };
        Assert.That(speed.VesselSpeed, Is.EqualTo(10));
    }

    [Test]
    public void Test_Nautical()
    {
        var speed = new Speed
        {
            VesselSpeed = 10
        };
        Assert.That(speed.Nautical, Is.EqualTo(10));
    }

    [Test]
    public void Test_ToString_Default()
    {
        var speed = new Speed(10);
        var result = speed.ToString();
        StringAssert.Contains("10.00 KN", result);
    }

    [Test]
    public void Test_ToString_KN()
    {
        var speed = new Speed(10);
        var result = speed.ToString(Constents.UNIT_KN);
        StringAssert.Contains("10.00 KN", result);
    }

    [Test]
    public void Test_ToString_MS()
    {
        var speed = new Speed(10);
        var result = speed.ToString(Constents.UNIT_MS);
        StringAssert.Contains("5.14 MS", result);
    }
}