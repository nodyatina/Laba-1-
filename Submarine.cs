using System;

public class Submarine : Ship, ISurfaceVessel
{
    public decimal SpeedUnderwater { get; private set; }
    public int EmergencyResurfaceTime { get; private set; }

    public Submarine(decimal speed, decimal speedUnderwater, int crew, int emergencyResurfaceTime)
    {
        Speed = speed;
        SpeedUnderwater = speedUnderwater;
        Crew = crew;
        EmergencyResurfaceTime = emergencyResurfaceTime;
    }

    public override string GetDescription()
    {
        return "Submarine";
    }
}
