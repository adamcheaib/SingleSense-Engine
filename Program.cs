using DiscordBattler.GameObjects;

namespace DiscordBattler;

public class DiscordBattler
{
    public static void Main()
    {
        string input = "east";
        char charInput = 'e';
        Console.WriteLine(Directions.ControlMovement(input));
        Console.WriteLine(Directions.ControlMovement(charInput));
    }
}