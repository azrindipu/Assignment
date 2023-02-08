using Assignment.vessels.@base;

namespace Assignment.helper.abstractFactory;

public interface IFerryFactory
{
    Vessel CreateFerry(string name, DateTime yearBuilt, double speed, int passengers);
}