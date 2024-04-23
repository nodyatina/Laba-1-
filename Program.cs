using System;

class Program
{
    static void Main()
    {
        SailingShip sailingShip = new SailingShip(10m, 20, 3, 2);
        Submarine submarine = new Submarine(15m, 8m, 30, 5);
        DieselShip dieselShip = new DieselShip(25m, 5000m, 50, 1000m);
        NuclearShip nuclearShip = new NuclearShip(30m, 10000m, 80, "Brand X");
        Steamship steamship = new Steamship(12m, 25, 5m);

        Console.WriteLine(sailingShip.GetDescription());
        Console.WriteLine(submarine.GetDescription());
        Console.WriteLine(dieselShip.GetDescription());
        Console.WriteLine(nuclearShip.GetDescription());
        Console.WriteLine(steamship.GetDescription());
    }
}