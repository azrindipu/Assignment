using Assignment.vessels.@base;

namespace Assignment.helper.abstractFactory;

public interface ITugboatFactory
{
    Vessel CreateTugboat(string name, DateTime yearBuilt, double speed, double maxForce);
}