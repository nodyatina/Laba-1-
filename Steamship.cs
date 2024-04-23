using System;

public class Steamship : Ship, ISurfaceVessel
{
    public decimal WheelDiameter { get; private set; }

    public Steamship(decimal speed, int crew, decimal wheelDiameter)
    {
        Speed = speed;
        Crew = crew;
        WheelDiameter = wheelDiameter;
    }

    public override string GetDescription()
    {
        return "Steamship";
    }
}
