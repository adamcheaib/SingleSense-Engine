using DiscordBattler.GameObjects;

namespace DiscordBattler.GameEngine;

public static class Map
{
    /*
    Everything needs to be placed on the map using coordinates. It is coordinates that they receive in each instance.
    A map will be represented by 0's and 1's. 0 are tiles you can walk on and 1's are obstacles.

    The question remains: how do I place the different things on the map?
     */

    private static int?[,] TileMap =
    {
        { null, null, null, null, null, null, null, null },
        { null, 1, 1, 1, 1, 1, null, null },
        { null, 1, null, null, null, 1, null, null },
        { null, 1, null, 1, null, 1, null, null },
        { null, 1, null, null, null, 1, null, null },
        { null, 1, 1, 1, 1, 1, null, null },
        { null, null, null, null, null, null, null, null }
    };

    public static bool CheckMovePossibility(Player player, string direction)
    {
        char directionToMove = char.ToLower(direction[0]);

        switch (directionToMove)
        {
            case 'n':
                return player.Y - 1 >= 0 && TileMap[player.Y - 1, player.X] != null;
            case 's':
                return player.Y + 1 < TileMap.Length && TileMap[player.Y + 1, player.X] != null;
            case 'w':
                return player.X - 1 >= 0 && TileMap[player.Y, player.X - 1] != null;
            case 'e':
                /* The GetLength method is used to check the length of the column since this is a 2D-array and
                 not a jagged array (jagged being an array with different column lengths).*/
                return player.X + 1 < TileMap.GetLength(0) && TileMap[player.Y, player.X + 1] != null;
        }

        return false;
    }

    public static void PrintMap(Player player)
    {
        Console.WriteLine(TileMap.GetLength(1));

        Console.WriteLine("\t\t\t===== MAP =====");
        Console.WriteLine("\t\tThe tile I am on is marked with green.\n\t\tThe O's are places I can walk.");
        for (int row = 0; row < TileMap.GetLength(0); row++)
        {
            for (int column = 0; column < TileMap.GetLength(1); column++)
            {
                int? entry = TileMap[row, column];
                if (player.X == column && player.Y == row)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\tX");
                    Console.ResetColor();
                    continue;
                }

                if (entry == null) Console.Write("\t-");
                else Console.Write($"\tO");
            }

            Console.WriteLine();
        }
    }
}