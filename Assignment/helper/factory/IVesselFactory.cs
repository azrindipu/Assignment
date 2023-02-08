using Assignment.helper.abstractFactory;
using Assignment.vessels.@base;

namespace Assignment.helper.factory;

public interface IVesselFactory
{
    Vessel CreateVessel(IFerryFactory factory);
    Vessel CreateVessel(ITugboatFactory factory);
    Vessel CreateVessel(ISubmarineFactory factory);
}