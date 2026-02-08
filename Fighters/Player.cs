namespace DiscordBattler.GameObjects;

public class Player(
    string name,
    string description,
    int health,
    int energy,
    int power,
    int defence,
    int criticalChance,
    int x,
    int y
) : Combatant(name, description, health, energy, power, defence, criticalChance, x, y)
{

    private enum Actions
    {
        Attack = 0,
        Defend,
        Abilities,
        Items,
        Run
    }
    
    
    
    public void Move(string direction)
    {
        if (!MovementManager.MoveUnit(this, direction))
        {
            return;
        }

        Console.WriteLine($"I moved {direction}");
        // Scans the current scene and what is going on.
    }

    // Prints out the different actions that a player can make. This will be used in the battle-system.
    public void PrintActions()
    {
    }
}