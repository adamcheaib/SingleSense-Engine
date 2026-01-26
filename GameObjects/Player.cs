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
        if (!Movement.ControlMovement(direction))
        {
            Console.WriteLine($"I do not know where {direction} is");
            return;
        }

        switch (direction)
        {
            case "n":
            case "north":
            case "s":
            case "south":
                Console.WriteLine($"Y: {this.Y} currently.");
                this.Y += Movement.AddCoordinates(direction);
                Console.WriteLine($"Y is now {this.Y}");
                break;
            case "e":
            case "east":
            case "w":
            case "west":
                this.X += Movement.AddCoordinates(direction);
                break;
        }
    }
}