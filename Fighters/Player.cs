using DiscordBattler.GameObjects;

namespace DiscordBattler.Fighters;

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

    private enum PlayerActions
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{this.Name}: I cannot go there.");
            Console.ResetColor();
            return;
        }

        // TODO: Currently, if I move using the first letter of the direction, the output is "I moved [first letter]". This needs to be automated so that the direction name is printed out rather than what I input.
        Console.WriteLine($"{this.Name}: I moved {direction}");
        // Scans the current scene and what is going on.
    }

    // Prints out the different actions that a player can make. This will be used in the battle-system.
    public void PrintActions()
    {
    }
}