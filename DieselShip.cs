using System;

public class DieselShip : Ship, ISurfaceVessel
{
    public decimal Power { get; private set; }
    public decimal Range { get; private set; }

    public DieselShip(decimal speed, decimal power, int crew, decimal range)
    {
        Speed = speed;
        Power = power;
        Crew = crew;
        Range = range;
    }

    public override string GetDescription()
    {
        return "Diesel Ship";
    }
}
