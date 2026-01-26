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
        North = 1,
        East = 1,
        South = -1,
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

    public static bool ControlMovement(string input)
    {
        return _validDirections.ContainsKey(input);
    }

    public static bool ControlMovement(char input)
    {
        return _validDirections.ContainsKey(input.ToString());
    }

    public static int AddCoordinates(string input)
    {
        // Converts the enum value to its int counterpart.
        return (int)_validDirections[input];
    }
    
}