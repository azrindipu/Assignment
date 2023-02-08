using Assignment.util;

namespace Assignment.vessels.@base;

public abstract class Vessel : Speed
{
    private string _name;
    private DateTime _yearBuilt;
    private string _vesselType;
    public abstract void GetVesselInfo();

    public string Name
    {
        get => this._name;
        set { Validator.ValidateVesseleName(value); _name = value; }
    }

    public DateTime YearBuilt
    {
        get => this._yearBuilt;
        set { Validator.ValidateVesseleYearBuild(value); _yearBuilt = value; }
    }

    public string VesselType
    {
        get => this._vesselType;
        set { Validator.ValidateVesselType(value); this._vesselType = value; }
    }

    protected Vessel(string name, DateTime yearBuilt, string vesselType, double speed) : base(speed)
    {
        Validator.ValidateVesseleNameAndBuildYear(name, yearBuilt);
        this._name = name;
        this._yearBuilt = yearBuilt;
        this._vesselType = vesselType;
    }

    protected Vessel(string name, DateTime yearBuilt, string vesselType) : base()
    {
        Validator.ValidateVesseleNameAndBuildYear(name, yearBuilt);
        this._name = name;
        this._yearBuilt = yearBuilt;
        this._vesselType = vesselType;
    }

    public override string ToString()
    {
        return "Info: name: " + _name + ", yearBuilt: " + _yearBuilt.ToString() + ", vesselType: " + _vesselType + ", Speed: " + base.ToString();
    }
}