using Assignment.util;
using Assignment.vessels.@base;

namespace Assignment.vessels;

public class Submarine : Vessel
{
    private double maxDepth;

    public double MaxDepth
    {
        get { return this.maxDepth; }
        set { Validator.ValidateMaxDepth(value); this.maxDepth = value; }
    }

    public Submarine(string name, DateTime yearBuilt) : base(name, yearBuilt, Constents.VESSEL_TYPE_SUBMARINE)
    {
        this.MaxDepth = 0;
    }

    public Submarine(string name, DateTime yearBuilt, double speed, double maxDepth) : base(name, yearBuilt, Constents.VESSEL_TYPE_SUBMARINE, speed)
    {
        Validator.ValidateMaxDepth(maxDepth);
        this.MaxDepth = maxDepth;
    }

    public Submarine(string name, DateTime yearBuilt, double speed) : base(name, yearBuilt, Constents.VESSEL_TYPE_SUBMARINE, speed)
    {
        this.MaxDepth = 0;
    }

    public Submarine(string name, double maxDepth, DateTime yearBuilt) : base(name, yearBuilt, Constents.VESSEL_TYPE_SUBMARINE)
    {
        Validator.ValidateMaxDepth(maxDepth);
        this.MaxDepth = maxDepth;
    }

    public override void GetVesselInfo()
    {
        Console.WriteLine(this.ToString());
    }

    public override string ToString()
    {
        return "Info:  vesselType: " + base.VesselType + ", " + "name: " + base.Name + ", yearBuilt: " + base.YearBuilt.ToString() + ", " +
               " Speed: " + base.VesselSpeed + ", maxDepth: " + this.MaxDepth;
    }
}