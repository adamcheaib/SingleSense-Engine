namespace DiscordBattler.GameObjects;

/*

This class is mainly to control the movement of the user.

For example, if a user inputs "w" or "west", the static class will control whether the input was for
movement or not, and whether the input is valid or not.
 */

public static class Directions
{
    private enum ValidDirections
    {
        North,
        East,
        South,
        West
    }

    private static readonly Dictionary<string, ValidDirections> _validDirections = new Dictionary<string, ValidDirections>()
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
}