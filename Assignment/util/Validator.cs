using System.Collections;
using Assignment.vessels.@base;

namespace Assignment.util;

public class Validator
{
    public static void ValidateSpeed(double vesselSpeed)
  {
    if (vesselSpeed < 0) throw new ArgumentOutOfRangeException("Speed can not be less than zero.");
  }

  public static void ValidateVesseleNameAndBuildYear(String name, DateTime yearBuilt)
  {
    ValidateVesseleName(name);
    ValidateVesseleYearBuild(yearBuilt);
  }

  public static void ValidateVesseleName(String name)
  {
    if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Name can not be null or empty.");
  }

  public static void ValidateVesseleYearBuild(DateTime yearBuilt)
  {
    var timeDiff = Constents.TODAY - yearBuilt;
    if (timeDiff.Days > Constents.YEAR_THRESHOLD*Constents.DAYS_IN_A_YEAR) throw new ArgumentOutOfRangeException("yearBuilt is 20 years old");
  }

  public static void ValidateVesselType(string type)
  {
    if(string.IsNullOrEmpty(type)) throw new ArgumentNullException("Vessel type can not be null.");
    ArrayList types = new ArrayList
    {
      Constents.VESSEL_TYPE_FERRY,
      Constents.VESSEL_TYPE_TUGBOAT,
      Constents.VESSEL_TYPE_SUBMARINE
    };
    if (!types.Contains(type)) throw new ArgumentException("Vessel type is not matched.");
  }

  public static void ValidatePassengers(int passengers)
  {
    if (passengers < 0) throw new ArgumentOutOfRangeException("Number of passengers can be negative");
  }

  public static void ValidateMaxForce(double maxForce)
  {
    if (maxForce < 0) throw new ArgumentOutOfRangeException("Max force can not be negative");
  }

  public static void ValidateMaxDepth(double maxDepth)
  {
    if (maxDepth < 0) throw new ArgumentOutOfRangeException("Max depth can not be negative");
  }

  public static void ValidateUpperBound(int upperBound)
  {
    if (upperBound < 2) throw new ArgumentOutOfRangeException("Upper bound can not be less than 2");
  }

  public static void ValidateVesselsList(List<Vessel> vessels)
  {
    if (vessels == null || vessels.Count <= 0) throw new ArgumentNullException("Vessel list can not be empty or null");
  }
}