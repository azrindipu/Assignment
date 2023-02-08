using Assignment.util;
using Assignment.vessels;

namespace UnitTest.vesselTest;

public class VesselUnitTest
{
    [Test]
    public void Test_passengers()
    {
        var ferry = new Ferry(Constents.VESSEL_TYPE_FERRY_DEFAULT_NAME, Constents.TODAY)
        {
            passengers = 10
        };
        Assert.That(ferry.passengers, Is.EqualTo(10));
    }
    
    [Test]
    public void Test_Constructor_With_Name_YearBuilt()
    {
        var ferry = new Ferry(Constents.VESSEL_TYPE_FERRY_DEFAULT_NAME, Constents.TODAY);
        Assert.That(ferry.passengers, Is.EqualTo(0));
    }
    
    [Test]
    public void Test_Constructor_With_Name_YearBuilt_Speed_Passengers()
    {
        var ferry = new Ferry(Constents.VESSEL_TYPE_FERRY_DEFAULT_NAME, Constents.TODAY, 10.5,10);
        Assert.That(ferry.passengers, Is.EqualTo(10));
        Assert.That(ferry.VesselSpeed, Is.EqualTo(10.5));
    }
    
    [Test]
    public void Test_Constructor_With_Name_YearBuilt_Speed()
    {
        var ferry = new Ferry(Constents.VESSEL_TYPE_FERRY_DEFAULT_NAME, Constents.TODAY, 10.5);
        Assert.That(ferry.VesselSpeed, Is.EqualTo(10.5));
    }
    
    [Test]
    public void Test_Constructor_With_Name_YearBuilt_Passengers()
    {
        var ferry = new Ferry(Constents.VESSEL_TYPE_FERRY_DEFAULT_NAME, Constents.TODAY, 10);
        Assert.That(ferry.passengers, Is.EqualTo(10));
    }
    
    [Test]
    public void Test_ToString()
    {
        DateTime dateTime = new DateTime(2019,05,09,9,15,0);
        var ferry = new Ferry(Constents.VESSEL_TYPE_FERRY_DEFAULT_NAME, dateTime, 10.5, 10);
        var result = ferry.ToString();
        StringAssert.Contains("Info:  vesselType: Ferry, name: DEFAULT_FERRY_NAME, yearBuilt: 5/9/2019 9:15:00 AM,  Speed: 10.5, passengers: 10", result);
    }
    
    [Test]
    public void Test_GetVesselInfo()
    {
        DateTime dateTime = new DateTime(2019,05,09,9,15,0);
        var ferry = new Ferry(Constents.VESSEL_TYPE_FERRY_DEFAULT_NAME, dateTime, 10.5, 10);
        ferry.GetVesselInfo();
        var result = ferry.ToString();
        StringAssert.Contains("Info:  vesselType: Ferry, name: DEFAULT_FERRY_NAME, yearBuilt: 5/9/2019 9:15:00 AM,  Speed: 10.5, passengers: 10", result);
    }
}