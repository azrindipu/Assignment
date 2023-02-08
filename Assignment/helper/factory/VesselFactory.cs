using Assignment.helper.abstractFactory;
using Assignment.util;
using Assignment.vessels.@base;

namespace Assignment.helper.factory;

public class VesselFactory : IVesselFactory
{
    public Vessel CreateVessel(IFerryFactory factory)
    {
        return factory.CreateFerry(Constents.VESSEL_TYPE_FERRY_DEFAULT_NAME + Util.GetRand(1, 200),
            Constents.TODAY, Util.GetRand(1, 200), Util.GetRand(1, 200));
    }

    public Vessel CreateVessel(ITugboatFactory factory)
    {
        return factory.CreateTugboat(Constents.VESSEL_TYPE_TUGBOAT_DEFAULT_NAME + Util.GetRand(1, 200),
            Constents.TODAY, Util.GetRand(1, 200), Util.GetRand(1, 200));
    }

    public Vessel CreateVessel(ISubmarineFactory factory)
    {
        return factory.CreateSubmarine(Constents.VESSEL_TYPE_SUBMARINE_DEFAULT_NAME + Util.GetRand(1, 200),
            Constents.TODAY, Util.GetRand(1, 200), Util.GetRand(1, 200));
    }
}