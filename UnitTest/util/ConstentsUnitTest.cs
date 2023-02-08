using Assignment.util;

namespace UnitTest.util;

public class ConstentsUnitTest
{
    [Test]
    public void Test_YEAR_THRESHOLD()
    {
        Assert.That(Constents.YEAR_THRESHOLD, Is.EqualTo(20));
    }

    [Test]
    public void Test_DAYS_IN_A_YEAR()
    {
        Assert.That(Constents.DAYS_IN_A_YEAR, Is.EqualTo(365));
    }

    [Test]
    public void Test_MS_SCALE_FACTOR()
    {
        Assert.That(Constents.MS_SCALE_FACTOR, Is.EqualTo(0.514444));
    }

    [Test]
    public void Test_VESSEL_TYPE_FERRY()
    {
        Assert.That(Constents.VESSEL_TYPE_FERRY, Is.EqualTo("Ferry"));
    }

    [Test]
    public void Test_VESSEL_TYPE_TUGBOAT()
    {
        Assert.That(Constents.VESSEL_TYPE_TUGBOAT, Is.EqualTo("Tugboat"));
    }

    [Test]
    public void Test_VESSEL_TYPE_SUBMARINE()
    {
        Assert.That(Constents.VESSEL_TYPE_SUBMARINE, Is.EqualTo("Submarine"));
    }

    [Test]
    public void Test_VESSEL_TYPE_FERRY_DEFAULT_NAME()
    {
        Assert.That(Constents.VESSEL_TYPE_FERRY_DEFAULT_NAME, Is.EqualTo("DEFAULT_FERRY_NAME"));
    }

    [Test]
    public void Test_VESSEL_TYPE_TUGBOAT_DEFAULT_NAME()
    {
        Assert.That(Constents.VESSEL_TYPE_TUGBOAT_DEFAULT_NAME, Is.EqualTo("DEFAULT_TUGBOAT_NAME"));
    }

    [Test]
    public void Test_VESSEL_TYPE_SUBMARINE_DEFAULT_NAME()
    {
        Assert.That(Constents.VESSEL_TYPE_SUBMARINE_DEFAULT_NAME, Is.EqualTo("DEFAULT_SUBMARINE_NAME"));
    }

    [Test]
    public void Test_UNIT_MS()
    {
        Assert.That(Constents.UNIT_MS, Is.EqualTo("MS"));
    }

    [Test]
    public void Test_UNIT_KN()
    {
        Assert.That(Constents.UNIT_KN, Is.EqualTo("KN"));
    }

    [Test]
    public void Test_TODAY()
    {
        Assert.That(Constents.TODAY.ToString("MM/dd/yyyy"), Is.EqualTo(DateTime.Now.ToString("MM/dd/yyyy")));
    }
}