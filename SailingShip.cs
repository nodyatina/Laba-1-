using System;

public class SailingShip : Ship, ISurfaceVessel
{
    public int MastCount { get; private set; }
    public int DeckCount { get; private set; }

    public SailingShip(decimal speed, int crew, int mastCount, int deckCount)
    {
        Speed = speed;
        Crew = crew;
        MastCount = mastCount;
        DeckCount = deckCount;
    }

    public override string GetDescription()
    {
        return $"Sailing Ship with {MastCount} masts and {DeckCount} decks";
    }
}
