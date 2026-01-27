using DiscordBattler.GameEngine;
namespace DiscordBattler.GameObjects;

/*

This class is mainly to control the movement of the user.

For example, if a user inputs "w" or "west", the static class will control whether the input was for
movement or not, and whether the input is valid or not.
 */

public static class Movement
{
    private enum ValidDirections
    {
        North = -1,
        East = 1,
        South = 1,
        West = -1
    }

    private static readonly Dictionary<string, ValidDirections> _validDirections =
        new Dictionary<string, ValidDirections>()
        {
            { "north", ValidDirections.North },
            { "n", ValidDirections.North },
            { "east", ValidDirections.East },
            { "e", ValidDirections.East },
            { "south", ValidDirections.South },
            { "s", ValidDirections.South },
            { "west", ValidDirections.West },
            { "w", ValidDirections.West }
        };

    private static bool ControlMovement(string input)
    {
        return _validDirections.ContainsKey(input.ToLower());
    }

    private static bool ControlMovement(char input)
    {
        return _validDirections.ContainsKey(input.ToString());
    }

    public static int AddCoordinates(string input)
    {
        // Converts the enum value to its int counterpart.
        return (int)_validDirections[input];
    }

    public static bool MoveUnit(Player player, string direction)
    {
        // Validates the input for the direction.
        if (!ControlMovement(direction))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Unknown direction: {direction}");
            Console.ResetColor();
            return false;
        }

        // Checks if the tile is available.
        if (Map.CheckVacancyOfTile(player, direction))
        {
            switch (direction[0])
            {
                case 'n':
                case 's':
                    player.Y += Movement.AddCoordinates(direction);
                    return true;
                case 'e':
                case 'w':
                    player.X += Movement.AddCoordinates(direction);
                    return true;
                default: Console.WriteLine("Weird bug here!"); break;
            }
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("I cannot go there.");
        Console.ResetColor();
        return false;
    }
}