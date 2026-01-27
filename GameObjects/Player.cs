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
    public void Move(string direction)
    {
        if (!Movement.MoveUnit(this, direction))
        {
            return;
        }

        Console.WriteLine($"I moved {direction}");
    }
}