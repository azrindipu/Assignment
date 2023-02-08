using System.Collections;
using Assignment.util;
using Assignment.vessels;
using Assignment.vessels.@base;

namespace UnitTest.util;

public class ValidatorUnitTest
{
    [Test]
    public void Test_Valid_ValidateSpeed()
    {
        Validator.ValidateSpeed(10);
        Assert.Pass();
    }
    
    [Test]
    public void Test_Invalid_ValidateSpeed()
    {
        Assert.That(() => Validator.ValidateSpeed(-10), Throws.TypeOf<ArgumentOutOfRangeException>());
    }
    
    [Test]
    public void Test_Valid_ValidateVesseleName()
    {
        Validator.ValidateVesseleName("test_name");
        Assert.Pass();
    }
    
    [Test]
    public void Test_Invalid_ValidateVesseleName()
    {
        Assert.That(() => Validator.ValidateVesseleName(null), Throws.TypeOf<ArgumentNullException>());
    }
    
    [Test]
    public void Test_Valid_ValidateVesseleYearBuild()
    {
        Validator.ValidateVesseleYearBuild(Constents.TODAY.AddYears(-19));
        Assert.Pass();
    }
    
    [Test]
    public void Test_Invalid_ValidateVesseleYearBuild()
    {
        var dateTime = DateTime.Now.AddYears(-20);
        Assert.That(() => Validator.ValidateVesseleYearBuild(dateTime), Throws.TypeOf<ArgumentOutOfRangeException>());
    }
    
    [Test]
    public void Test_Valid_ValidateVesselType_Ferry()
    {
        Validator.ValidateVesselType(Constents.VESSEL_TYPE_FERRY);
        Assert.Pass();
    }
    
    [Test]
    public void Test_Valid_ValidateVesselType_Tugboat()
    {
        Validator.ValidateVesselType(Constents.VESSEL_TYPE_TUGBOAT);
        Assert.Pass();
    }
    
    [Test]
    public void Test_Valid_ValidateVesselType_Submarine()
    {
        Validator.ValidateVesselType(Constents.VESSEL_TYPE_SUBMARINE);
        Assert.Pass();
    }
    
    [Test]
    public void Test_Invalid_ValidateVesselType_Null()
    {
        Assert.That(() => Validator.ValidateVesselType(null), Throws.TypeOf<ArgumentNullException>());
    }
    
    [Test]
    public void Test_Invalid_ValidateVesselType()
    {
        Assert.That(() => Validator.ValidateVesselType("Type"), Throws.TypeOf<ArgumentException>());
    }
    
    [Test]
    public void Test_Valid_ValidatePassengers()
    {
        Validator.ValidatePassengers(10);
        Assert.Pass();
    }
    
    [Test]
    public void Test_Invalid_ValidatePassengers()
    {
        Assert.That(() => Validator.ValidatePassengers(-10), Throws.TypeOf<ArgumentOutOfRangeException>());
    }
    
    [Test]
    public void Test_Valid_ValidateMaxForce()
    {
        Validator.ValidateMaxForce(10);
        Assert.Pass();
    }
    
    [Test]
    public void Test_Invalid_ValidateMaxForce()
    {
        Assert.That(() => Validator.ValidateMaxForce(-10), Throws.TypeOf<ArgumentOutOfRangeException>());
    }
    
    [Test]
    public void Test_Valid_ValidateMaxDepth()
    {
        Validator.ValidateMaxDepth(10);
        Assert.Pass();
    }
    
    [Test]
    public void Test_Invalid_ValidateMaxDepth()
    {
        Assert.That(() => Validator.ValidateMaxDepth(-10), Throws.TypeOf<ArgumentOutOfRangeException>());
    }
    
    [Test]
    public void Test_Valid_ValidateUpperBound()
    {
        Validator.ValidateUpperBound(10);
        Assert.Pass();
    }
    
    [Test]
    public void Test_Invalid_ValidateUpperBound()
    {
        Assert.That(() => Validator.ValidateUpperBound(-10), Throws.TypeOf<ArgumentOutOfRangeException>());
    }
    
    [Test]
    public void Test_Valid_ValidateVesselsList()
    {
        var list = new List<Vessel>()
        {
            new Ferry(Constents.VESSEL_TYPE_FERRY_DEFAULT_NAME, Constents.TODAY)
        };
        Validator.ValidateVesselsList(list);
        Assert.Pass();
    }
    
    [Test]
    public void Test_Invalid_ValidateVesselsList()
    {
        Assert.That(() => Validator.ValidateVesselsList(null), Throws.TypeOf<ArgumentNullException>());
    }
    
    
}