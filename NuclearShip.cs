using System;

public class NuclearShip : Ship, ISurfaceVessel
{
    public decimal Power { get; private set; }
    public string ReactorBrand { get; private set; }

    public NuclearShip(decimal speed, decimal power, int crew, string reactorBrand)
    {
        Speed = speed;
        Power = power;
        Crew = crew;
        ReactorBrand = reactorBrand;
    }

    public override string GetDescription()
    {
        return "Nuclear Ship";
    }
}
