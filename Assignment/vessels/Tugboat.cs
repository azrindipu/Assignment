using Assignment.util;
using Assignment.vessels.@base;

namespace Assignment.vessels;

public class Tugboat : Vessel
{
    private double maxForce;

    public double MaxForce
    {
        get { return this.maxForce; }
        set { Validator.ValidateMaxForce(value); this.maxForce = value; }
    }

    public Tugboat(string name, DateTime yearBuilt) : base(name, yearBuilt, Constents.VESSEL_TYPE_TUGBOAT)
    {
        this.MaxForce = 0;
    }

    public Tugboat(string name, DateTime yearBuilt, double speed, double maxForce) : base(name, yearBuilt, Constents.VESSEL_TYPE_TUGBOAT, speed)
    {
        Validator.ValidateMaxForce(maxForce);
        this.MaxForce = maxForce;
    }

    public Tugboat(string name, DateTime yearBuilt, double speed) : base(name, yearBuilt, Constents.VESSEL_TYPE_TUGBOAT, speed)
    {
        this.MaxForce = 0;
    }

    public Tugboat(string name, double maxForce, DateTime yearBuilt) : base(name, yearBuilt, Constents.VESSEL_TYPE_TUGBOAT)
    {
        Validator.ValidateMaxForce(maxForce);
        this.MaxForce = maxForce;
    }

    public override void GetVesselInfo()
    {
        Console.WriteLine(this.ToString());
    }

    public override string ToString()
    {
        return "Info:  vesselType: " + base.VesselType + ", " + "name: " + base.Name + ", yearBuilt: " + base.YearBuilt.ToString() + ", " +
               " Speed: " + base.VesselSpeed + ", maxForce: " + this.MaxForce;
    }
}