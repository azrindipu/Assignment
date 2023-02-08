using Assignment.util;
using Assignment.vessels.@base;

namespace Assignment.fleet;

public class Fleet : IFleet
{
    private List<Vessel> vessels;

    public Fleet(List<Vessel> vessels)
    {
        Validator.ValidateVesselsList(vessels);
        this.vessels = vessels;
    }

    public void CountEachTypeOfVessel()
    {
        Dictionary<string, int> typeCountDictionary = new Dictionary<string, int>();
        foreach (Vessel vessel in this.vessels)
        {
            if (typeCountDictionary.ContainsKey(vessel.VesselType))
            {
                int prevCount = typeCountDictionary[vessel.VesselType];
                typeCountDictionary.Remove(vessel.VesselType);
                typeCountDictionary.Add(vessel.VesselType, prevCount + 1);
            }
            else
            {
                typeCountDictionary.Add(vessel.VesselType, 1);
            }
        }
        Console.WriteLine("Each vessel type count: ");
        List<string> keys = typeCountDictionary.Keys.ToList();
        foreach (string key in keys)
        {
            Console.WriteLine(key + ": " + typeCountDictionary[key]);
        }
    }

    public void PrintInfoAllVessel()
    {
        foreach (Vessel vessel in vessels)
        {
            vessel.GetVesselInfo();
        }
    }

    public void PrintMaxSpeedOfEachTypeOfVessel()
    {
        Dictionary<string, double> typeSpeedDictionary = new Dictionary<string, double>();
        foreach (Vessel vessel in vessels)
        {
            if (typeSpeedDictionary.ContainsKey(vessel.VesselType))
            {
                double prevValue = typeSpeedDictionary[vessel.VesselType];
                typeSpeedDictionary.Remove(vessel.VesselType);
                typeSpeedDictionary.Add(vessel.VesselType, Math.Max(prevValue, vessel.VesselSpeed));
            }
            else
            {
                typeSpeedDictionary.Add(vessel.VesselType, vessel.VesselSpeed);
            }
        }
        Console.WriteLine("Max speed for each vessel type: ");
        List<string> keys = typeSpeedDictionary.Keys.ToList();
        foreach (string key in keys)
        {
            Console.WriteLine(key + ": " + typeSpeedDictionary[key]);
        }
    }

    public void TotalVessels()
    {
        Console.WriteLine("Total vessels: " + this.vessels.Count);
    }
}