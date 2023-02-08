using Assignment.util;
using Assignment.vessels;
using Assignment.vessels.@base;

namespace Assignment.helper.abstractFactory;

public class TugboatFactory : ITugboatFactory
{
    private Tugboat vessel;

    public TugboatFactory()
    {
        this.vessel = new Tugboat(Constents.VESSEL_TYPE_TUGBOAT_DEFAULT_NAME, Constents.TODAY);
    }
    
    public Vessel CreateTugboat(string name, DateTime yearBuilt, double speed, double maxForce)
    {
        this.vessel.Name = name;
        this.vessel.YearBuilt = yearBuilt;
        this.vessel.VesselSpeed = speed;
        this.vessel.MaxForce = maxForce;
        return this.vessel;
    }
}