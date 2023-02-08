using Assignment.util;
using Assignment.vessels;
using Assignment.vessels.@base;

namespace Assignment.helper.abstractFactory;

public class FerryFactory : IFerryFactory
{
    private Ferry vessel;

    public FerryFactory()
    {
        this.vessel = new Ferry(Constents.VESSEL_TYPE_FERRY_DEFAULT_NAME, Constents.TODAY);
    }

    public Vessel CreateFerry(string name, DateTime yearBuilt, double speed, int passengers)
    {
        this.vessel.Name = name;
        this.vessel.YearBuilt = yearBuilt;
        this.vessel.VesselSpeed = speed;
        this.vessel.passengers = passengers;
        return this.vessel;
    }
}