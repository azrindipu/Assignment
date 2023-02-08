using System;
using Assignment.fleet;
using Assignment.helper;
using Assignment.vessels.@base;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimulationHelper simulationHelper = new SimulationHelper();
            List<Vessel> vessels = simulationHelper.CreateVariousTypesOfVessel(200);
            IFleet fleet = new Fleet(vessels);
            fleet.TotalVessels();
            fleet.CountEachTypeOfVessel();
            fleet.PrintMaxSpeedOfEachTypeOfVessel();
            fleet.PrintInfoAllVessel();
        }
    }
}