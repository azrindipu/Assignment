using Assignment.vessels.@base;

namespace Assignment.helper.abstractFactory;

public interface ISubmarineFactory
{
    Vessel CreateSubmarine(string name, DateTime yearBuilt, double speed, double maxDepth);
}