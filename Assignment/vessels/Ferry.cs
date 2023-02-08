using Assignment.util;
using Assignment.vessels.@base;

namespace Assignment.vessels;

public class Ferry : Vessel
{
    public int passengers;

    public Ferry(string name, DateTime yearBuilt) : base(name, yearBuilt, Constents.VESSEL_TYPE_FERRY)
    {
        this.passengers = 0;
    }

    public Ferry(string name, DateTime yearBuilt, double speed, int passengers) : base(name, yearBuilt,
        Constents.VESSEL_TYPE_FERRY, speed)
    {
        Validator.ValidatePassengers(passengers);
        this.passengers = passengers;
    }

    public Ferry(string name, DateTime yearBuilt, double speed) : base(name, yearBuilt, Constents.VESSEL_TYPE_FERRY,
        speed)
    {
        this.passengers = 0;
    }

    public Ferry(string name, DateTime yearBuilt, int passengers) : base(name, yearBuilt, Constents.VESSEL_TYPE_FERRY)
    {
        Validator.ValidatePassengers(passengers);
        this.passengers = passengers;
    }

    public override void GetVesselInfo()
    {
        Console.WriteLine(this.ToString());
    }

    public override string ToString()
    {
        return "Info:  vesselType: " + base.VesselType + ", " + "name: " + base.Name + ", yearBuilt: " +
               base.YearBuilt + ", " +
               " Speed: " + base.VesselSpeed + ", passengers: " + this.passengers;
    }
}