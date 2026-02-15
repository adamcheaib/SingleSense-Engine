using DiscordBattler.Fighters;
using DiscordBattler.GameEngine;
namespace DiscordBattler.GameObjects;

/*

This class is mainly to control the movement of the user.

For example, if a user inputs "w" or "west", the static class will control whether the input was for
movement or not, and whether the input is valid or not.
 */

public static class MovementManager
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

    private static bool ControlMovementInput(string input)
    { 
        return _validDirections.ContainsKey(input.ToLower());
    }

    private static bool ControlMovementInput(char input)
    {
        return _validDirections.ContainsKey(input.ToString());
    }
 
    // Gets the int to add/subtract to the Player's position. Based on the _validDirections dictionary.
    private static int GetCoordinateValues(string input)
    {
        // Converts the enum value to its integer counterpart.
        return (int)_validDirections[input];
    }

    public static bool MoveUnit(Player player, string direction)
    {
        // Validates the input for the direction.
        if (!ControlMovementInput(direction))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Unknown direction: {direction}");
            Console.ResetColor();
            return false;
        }

        // Checks if the tile is available.
        if (MapManager.CheckMovePossibility(player, direction))
        {
            switch (direction[0])
            {
                case 'n':
                case 's':
                    player.Y += MovementManager.GetCoordinateValues(direction);
                    return true;
                case 'e':
                case 'w':
                    player.X += MovementManager.GetCoordinateValues(direction);
                    return true;
                default: Console.WriteLine("Movement Manager (error): Weird bug here!"); break;
            }
        }

        return false;
    }
}