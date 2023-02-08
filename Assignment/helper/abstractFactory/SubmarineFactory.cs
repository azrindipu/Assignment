using Assignment.util;
using Assignment.vessels;
using Assignment.vessels.@base;

namespace Assignment.helper.abstractFactory;

public class SubmarineFactory : ISubmarineFactory
{
    private Submarine vessel;

    public SubmarineFactory()
    {
        this.vessel = new Submarine(Constents.VESSEL_TYPE_SUBMARINE_DEFAULT_NAME, Constents.TODAY);
    }
    
    public Vessel CreateSubmarine(string name, DateTime yearBuilt, double speed, double maxDepth)
    {
        this.vessel.Name = name;
        this.vessel.YearBuilt = yearBuilt;
        this.vessel.VesselSpeed = speed;
        this.vessel.MaxDepth = maxDepth;
        return this.vessel;
    }
}