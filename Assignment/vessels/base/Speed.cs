using System;
using System.Globalization;
using Assignment.util;

public class Speed : IFormattable
{
    private double vesselSpeed;

    public double VesselSpeed
    {
        get { return this.vesselSpeed; }
        set { Validator.ValidateSpeed(value); this.vesselSpeed = value; }
    }

    public Speed()
    {
        this.vesselSpeed = 0;
    }

    public Speed(double vesselSpeed)
    {
        Validator.ValidateSpeed(vesselSpeed);
        this.vesselSpeed = vesselSpeed;
    }

    public double Nautical
    {
        get { return vesselSpeed; }
    }

    public double MeterPerSecond
    {
        get { return vesselSpeed * Constents.MS_SCALE_FACTOR; }
    }

    public override string ToString()
    {
        return this.ToString(Constents.UNIT_KN, CultureInfo.CurrentCulture);
    }

    public string ToString(string format)
    {
        return this.ToString(format, CultureInfo.CurrentCulture);
    }

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        if (String.IsNullOrEmpty(format)) format = Constents.UNIT_KN;
        if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;
        if (string.Equals(format, Constents.UNIT_KN))
        {
            return Nautical.ToString("F2", formatProvider) + " " + Constents.UNIT_KN;
        }
        else if (string.Equals(format, Constents.UNIT_MS))
        {
            return MeterPerSecond.ToString("F2", formatProvider) + " " + Constents.UNIT_MS;
        }
        throw new NotImplementedException();
    }
}