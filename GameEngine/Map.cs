namespace DiscordBattler.GameEngine;

public static class Map
{
    /*
    Everything needs to be placed on the map using coordinates. It is coordinates that they receive in each instance.
    A map will be represented by 0's and 1's. 0 are tiles you can walk on and 1's are obstacles.

    The question remains: how do I place the different things on the map?
     */

    public static int?[,] TileMap =
    {
        { null, null, null, null, null, null, null, null },
        { null, 1, 1, 1, 1, 1, null, null },
        { null, 1, null, null, null, 1, null, null },
        { null, 1, null, 1, null, 1, null, null },
        { null, 1, null, null, null, 1, null, null },
        { null, 1, 1, 1, 1, 1, null, null },
        { null, null, null, null, null, null, null, null }
    };
}