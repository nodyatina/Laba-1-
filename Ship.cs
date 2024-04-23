using System;

public abstract class Ship
{
    public decimal Speed { get; protected set; }
    public int Crew { get; protected set; }

    public abstract string GetDescription();
}
