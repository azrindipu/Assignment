using Assignment.helper.abstractFactory;
using Assignment.helper.factory;
using Assignment.util;
using Assignment.vessels.@base;

namespace Assignment.helper;

public class SimulationHelper
{
    public List<Vessel> CreateVariousTypesOfVessel(int upperbound)
    {
        Validator.ValidateUpperBound(upperbound);
        List<Vessel> vessels = new List<Vessel>();
        int limit = Util.GetRand(1, upperbound);
        IVesselFactory vesselFactory = new VesselFactory();
        IFerryFactory ferryFactory = new FerryFactory();
        ITugboatFactory tugboatFactory = new TugboatFactory();
        ISubmarineFactory submarineFactory = new SubmarineFactory();
        for (int i = 1; i <= limit; i++)
        {
            Vessel vessel;
            if (i % 2 == 0)
            {
                vessel = vesselFactory.CreateVessel(ferryFactory);
            }
            else
            {
                if (Util.GetRand(1, 20) % 2 == 0)
                {
                    vessel = vesselFactory.CreateVessel(tugboatFactory);
                }
                else
                {
                    vessel = vesselFactory.CreateVessel(submarineFactory);
                }
            }
            vessels.Add(vessel);
        }
        return vessels;
    }
}